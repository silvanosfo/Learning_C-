using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Diversos;

namespace ProjCredDeb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AtualizaLista();
            LimpaGrid();
            this.Text = "Projeto Créditos & Débitos";
            lblAddMov.Text = "------------------------------------------------------ ADICIONAR NOVO MOVIMENTO: ------------------------------------------------------";
            lblData.Text = "DATA:";
            lblDesc.Text = "DESCRIÇÃO:";
            cbxCredDeb.Items.Add("CRÉDITO");
            cbxCredDeb.Items.Add("DÉBITO");
            cbxCredDeb.SelectedIndex = 0;
            btnInserir.Text = "INSERIR";
        }
        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            Conecta obj = new Conecta();

            if (txtNome.Text == "")
            {
                obj.strSQL = "SELECT id, nome FROM cliente;";
            }
            else
            {
                obj.strSQL = "SELECT id, nome FROM cliente WHERE nome LIKE '" + txtNome.Text + "%';";
            }

            lstNomes.DisplayMember = "nome";
            lstNomes.ValueMember = "id";
            lstNomes.DataSource = obj.BuscarDados();
        }
        private void LimpaGrid()
        {
            dgvMov.DataSource = null;
            dgvMov.Rows.Clear();
            dgvMov.Columns.Clear();
            txtTotCred.Text = 0.ToString();
            txtTotDeb.Text = 0.ToString();

        }
        private void CalcularSaldo()
        {
            if (!dgvMov.Columns.Contains("saldo"))
            {
                dgvMov.Columns.Add("saldo", "saldo");
            }

            double saldo = 0;
            double creditos = 0;
            double debitos = 0;
            double totalCred = 0;
            double totalDebit = 0;

            for (int i = 0; i < dgvMov.Rows.Count; i++)
            {
                bool bCred = double.TryParse(Convert.ToString(dgvMov.Rows[i].Cells[3].Value),out creditos);
                
                
                if (!bCred) creditos = 0;

                bool bDeb = double.TryParse(Convert.ToString(dgvMov.Rows[i].Cells[4].Value), out debitos);
                if (!bDeb) debitos = 0;

                saldo = saldo + creditos - debitos;
                dgvMov.Rows[i].Cells[5].Value = saldo;

                totalCred+= creditos;
                totalDebit+= debitos;
            }
                txtTotCred.Text = totalCred.ToString();
                txtTotDeb.Text = totalDebit.ToString();
        }
        private void lstNomes_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizaGrid();
        }
        private void AtualizaGrid()
        {
            LimpaGrid();
            Conecta obj = new Conecta();
            obj.strSQL = "SELECT id, data, descricao, credito, debito FROM movimento WHERE id_cliente = " + lstNomes.SelectedValue + " ORDER BY data;";
            dgvMov.DataSource = obj.BuscarDados();

            CalcularSaldo();

            FormatarGrid formatador = new FormatarGrid();
            formatador.Formatar(dgvMov);
        }
        private void btnInserir_Click(object sender, EventArgs e)
        {
            Conecta obj = new Conecta();
            string credOuDeb = "";
            string bonito = "";

            if (cbxCredDeb.SelectedIndex == 0)
            {
                credOuDeb = "credito";
                bonito = "crédito: ";

            }
            else if (cbxCredDeb.SelectedIndex == 1)
            {
                credOuDeb = "debito";
                bonito = "débito: ";
            }

            obj.strSQL = "INSERT INTO movimento (data, descricao, " + credOuDeb + ", id_cliente) " +
                         "VALUES ('" + Convert.ToDateTime(dtpData.Value) + "', '" + txtDesc.Text + "', " + 
                         Convert.ToInt32(txtCredDeb.Text) + ", " + (int)lstNomes.SelectedValue + ");";

            var result = MessageBox.Show(Convert.ToString(dtpData.Value) + 
                            "\nCliente: " + lstNomes.GetItemText(lstNomes.SelectedItem) + 
                            "\nDescrição: " + txtDesc.Text +
                            "\nValor " + bonito + txtCredDeb.Text +
                            "\n\n\nCONFIRMA?", "VERIFIQUE OS DADOS", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                obj.BuscarDados();
                AtualizaGrid();
            }
        }
        private void inserirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClientesInsere formClientes = new FormClientesInsere();
            formClientes.ControlosInserir();
            formClientes.ShowDialog();

            AtualizaLista();
            LimpaGrid();
        }
        private void AtualizaLista()
        {
            // Atualiza lista Nomes
            Conecta execSQL = new Conecta();
            execSQL.strSQL = "SELECT id, nome FROM cliente;";
            lstNomes.DisplayMember = "nome";
            lstNomes.ValueMember = "id";
            lstNomes.DataSource = execSQL.BuscarDados();
        }
        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClientesInsere formClientes = new FormClientesInsere();
            formClientes.ControlosListar();
            formClientes.ShowDialog();
            
        }
        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClientesInsere formClientes = new FormClientesInsere();
            formClientes.ControlosAlterar();
            formClientes.ShowDialog();
        }
        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClientesInsere formClientes = new FormClientesInsere();
            formClientes.ControlosEliminar();
            formClientes.ShowDialog();

            AtualizaLista();
        }

        private void dgvMov_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.F2)
            {
                Conecta conecta = new Conecta();
                conecta.strSQL = $"UPDATE movimento SET descricao = {dgvMov.CurrentRow.Cells[2].Value} WHERE id = {dgvMov.CurrentRow.Cells[0].Value};";
                MessageBox.Show(conecta.strSQL);


            }
        }
    }
}
