using ClassConectaDB;
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

namespace SilvanoPRODUCAO2
{
    public partial class FormParte2 : Form
    {
        public FormParte2()
        {
            InitializeComponent();
            chkIncDesc.Checked = false;
            chkIncDesc.Text = "Incluir produtos descontinuados";
            chkExistZero.Checked = false;
            chkExistZero.Text= "Incluir produtos com existências a zero";
            lblProd.Text = "Escreva o nome de um produto:";
            btnProdProcurar.Text = "PROCURAR";

            // Popular DGV Inicial Prob 3
            PopularDataGridView();

            // Popular DGV Inicial Prob 4
            ConectaDB conecta = new ConectaDB();
            conecta.strSQL = "SELECT * FROM Produtos;";
            dgvProb4.DataSource = conecta.BuscarDados();

            // Popular ListBox Fornecedores
            conecta.strSQL = "SELECT NomeForn FROM Fornecedores";
            lstForn.DataSource = conecta.BuscarDados();
            lstForn.DisplayMember = "NomeForn";
            lstProdutos.Items.Clear();
        }

        private void chkIncDesc_CheckedChanged(object sender, EventArgs e)
        {
            PopularDataGridView();
        }

        private void chkExistZero_CheckedChanged(object sender, EventArgs e)
        {
            PopularDataGridView();
        }

        private void PopularDataGridView()
        {
            ConectaDB conecta = new ConectaDB();

            if (chkIncDesc.Checked && !(chkExistZero.Checked))
            {
                //Inclui descontinuados, sem inexistentes
                conecta.strSQL = "SELECT * FROM Produtos WHERE Existencias > 0;";

            }
            else if (chkExistZero.Checked && !(chkIncDesc.Checked))
            {
                //Inclui existencias 0, sem descontinuados
                conecta.strSQL = "SELECT * FROM Produtos WHERE Descontinuado = 0;";
            }
            else if (chkIncDesc.Checked && chkExistZero.Checked)
            {
                //Inclui descontinuados e existencias 0
                conecta.strSQL = "SELECT * FROM Produtos;";
            }
            else
            {
                //Sem descontinuados e sem inexistentes
                conecta.strSQL = "SELECT * FROM Produtos WHERE Descontinuado = 0 AND Existencias > 0;";
            }
            dgvProb3.DataSource = conecta.BuscarDados();
        }

        private void btnProdProcurar_Click(object sender, EventArgs e)
        {
            bool PRODNOTFOUND = true;
            for (int i = 0; i < dgvProb4.Rows.Count - 1; i++)
            {
                if (Convert.ToString(dgvProb4.Rows[i].Cells[1].Value) == txtNomeProd.Text)
                {
                    dgvProb4.Rows[i].Cells[6].Value = dgvProb4.Rows[i].Cells[7].Value;
                    PRODNOTFOUND = false;
                    break;
                }
            }

            if (PRODNOTFOUND)
            {
                txtProdNotFound.Text = "PRODUTO NÃO ENCONTRADO";
            }
        }

        private void lstForn_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConectaDB conecta = new ConectaDB();
            conecta.strSQL = "SELECT COUNT(Nome) FROM Produtos;";
            int total = Convert.ToInt32(conecta.BuscarDados().Rows[0][0]);

            //for (int i = 1; i <= total; i++)
            //{
            //    conecta.strSQL = $"SELECT * FROM Produtos WHERE CodProd = {i};";
            //    lstProdutos.Items.Add(Convert.ToString(conecta.BuscarDados().Rows[0][1]));
            //    lstProdutos.Items.Add(Convert.ToString(conecta.BuscarDados().Rows[0][5]));
            //}

            conecta.strSQL = "SELECT * FROM Produtos;";
            DataTable dt = conecta.BuscarDados();

            for (int i = 0; i < total; i++)
            {
                lstProdutos.Items.Add(dt.Rows[i][1]);
                lstProdutos.Items.Add(dt.Rows[i][5]);
            }
        }
    }
}
