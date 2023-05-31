using ClassConectaDB;
using System;
using System.Windows.Forms;

namespace SilvanoPRODUCAO2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblCidade.Text = "Escreva uma Cidade:";
            lblPais.Text = "Escolha um País:";
            lblIntervalo.Text = "Intervalo de Preços:";
            lblAte.Text = "<=>";
            btnContarProd.Text = "Contar Produtos";
            btnPart2.Text = "PARTE 2";

            // Popular Combobox Paises:
            ConectaDB conecta = new ConectaDB();
            conecta.strSQL = "SELECT DISTINCT Pais FROM Fornecedores";
            cbxPais.DataSource = conecta.BuscarDados();
            cbxPais.DisplayMember = "Pais";
        }

        private void cbxPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListarFornecedores();
        }

        private void ListarFornecedores()
        {
            if (txtCidade.Text != "")
            {
                ConectaDB conecta = new ConectaDB();
                conecta.strSQL = $"SELECT NomeForn FROM Fornecedores WHERE Cidade = '{txtCidade.Text}' AND Pais = '{cbxPais.Text}';";
                lstForn.DataSource = conecta.BuscarDados();
                lstForn.DisplayMember = "NomeForn";
            }
        }

        private void txtCidade_TextChanged(object sender, EventArgs e)
        {
            ListarFornecedores();
        }

        private void btnContarProd_Click(object sender, EventArgs e)
        {
            if (txtMin.Text != "" && txtMax.Text != "")
            {
                ConectaDB conecta = new ConectaDB();
                conecta.strSQL = $"SELECT COUNT(Nome) FROM Produtos WHERE Existencias = 0 AND Preco BETWEEN {Convert.ToDecimal(txtMin.Text)} AND {Convert.ToDecimal(txtMax.Text)};";
                MessageBox.Show($"Nº de produtos inexistentes no intervalo de preços: {Convert.ToString(conecta.BuscarDados().Rows[0][0])}");
            }
        }

        private void btnPart2_Click(object sender, EventArgs e)
        {
            FormParte2 fp2 = new FormParte2();
            fp2.ShowDialog();
        }
    }
}
