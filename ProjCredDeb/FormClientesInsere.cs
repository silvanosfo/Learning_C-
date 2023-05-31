using Diversos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.VisualBasic;


namespace ProjCredDeb
{
    public partial class FormClientesInsere : Form
    {
        public FormClientesInsere()
        {
            InitializeComponent();
            btnInsere.Text = "INSERE";
            btnAltera.Text = "ALTERAR";
            btnElimina.Text = "ELIMINAR";
            AtualizaLista();
        }
        private void AtualizaLista() 
        {
            Conecta execSQL = new Conecta();
            execSQL.strSQL = "SELECT id, nome FROM cliente;";
            lstClientes.DisplayMember = "nome";
            lstClientes.ValueMember = "id";
            lstClientes.DataSource = execSQL.BuscarDados();
        }
        private void btnInsere_Click(object sender, EventArgs e)
        {
            Conecta obj = new Conecta();
            obj.strSQL = "INSERT INTO cliente (nome) VALUES ('" + txtCliente.Text + "');";
            obj.BuscarDados();

            // Após inserir Hide este form
            this.Close();
        }
        public void ControlosListar()
        {
            txtCliente.Hide();
            btnInsere.Hide();
            btnAltera.Hide();
            btnElimina.Hide();
            this.Text = "Lista de Clientes";
        }
        public void ControlosInserir()
        {
            lstClientes.Hide();
            btnAltera.Hide();
            btnElimina.Hide();
            this.Text = "Inserir Cliente";
        }
        public void ControlosAlterar()
        {
            txtCliente.Hide();
            btnInsere.Hide();
            btnAltera.Hide();
            btnElimina.Hide();
            this.Text = "Alterar Nomes";
        }
        public void ControlosEliminar()
        {
            btnInsere.Hide();
            btnAltera.Hide();
            lstClientes.Hide();
            this.Text = "Eliminar Clientes";
        }
        private void lstClientes_DoubleClick(object sender, EventArgs e)
        {
            if (this.Text == "Alterar Nomes")
            {
                txtCliente.Show();
                btnAltera.Show();
            }
        }
        private void btnAltera_Click(object sender, EventArgs e)
        {
            Conecta execSQL = new Conecta();
            execSQL.strSQL = "UPDATE cliente SET nome = '" + txtCliente.Text + "' WHERE id = " + lstClientes.SelectedValue + ";";

            var result = MessageBox.Show("Optou por trocar o nome: " + lstClientes.GetItemText(lstClientes.SelectedItem) +
                "\nPor: " + txtCliente.Text +
                "\n\n\nCONFIRMA?", "VERIFIQUE OS DADOS", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                execSQL.BuscarDados();
                AtualizaLista();
            }
        }
        private void btnElimina_Click(object sender, EventArgs e)
        {
            Conecta execSQL = new Conecta();

            //SQL para testar se o nome existe
            execSQL.strSQL = "IF EXISTS (SELECT nome FROM cliente WHERE nome = '" + txtCliente.Text + "') " +
                                "BEGIN " +
                                "SELECT 1 " +
                                "END " +
                                "ELSE " + 
                                "BEGIN " +
                                "SELECT 0 " + 
                                "END ";

            //consoante se existe ou não
            if (Convert.ToBoolean(execSQL.BuscarDados().Rows[0][0]))
            {
                //SQL para contar movimentos
                execSQL.strSQL = "SELECT count(*) " +
                                 "FROM movimento M " +
                                 "INNER JOIN cliente C ON M.id_cliente = C.id " +
                                 "WHERE nome = '" + txtCliente.Text + "';";

                var result = MessageBox.Show("Vai apagar o cliente: " + txtCliente.Text +
                    "\nNº movimentos: " + Convert.ToString(execSQL.BuscarDados().Rows[0][0]) +
                    "\n\n\nCONFIRMA?", "VERIFIQUE OS DADOS", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string respostaUser = Interaction.InputBox("Insira o total de movimentos apresentados anteriormente que serão apagados", "Dupla Confirmação", "");

                    if (respostaUser == Convert.ToString(execSQL.BuscarDados().Rows[0][0]))
                    {
                        //apaga os movimentos
                        execSQL.strSQL = "DELETE M FROM movimento AS M " +
                                         "INNER JOIN cliente AS C ON M.id_cliente = C.id " +
                                         "WHERE nome = '" + txtCliente.Text + "';";
                        execSQL.BuscarDados();

                        //apaga o cliente
                        execSQL.strSQL = "DELETE FROM cliente " +
                                         "WHERE nome = '" + txtCliente.Text + "';";
                        execSQL.BuscarDados();

                        this.Close();
                    }
                    else
                    {
                        //nao inseriu o numero de moiventos correto
                        MessageBox.Show("Errou no numero de movimentos a serem apagados!\nOPERAÇÃO ANULADA!!!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Nome Incorreto ou Inexistente!");
            }
        }
    }
}
