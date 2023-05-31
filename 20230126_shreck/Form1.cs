using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20230126_shreck
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = "CÁLCULO DO VALOR DA AVENÇA";
            lblNome.Text = "NOME";
            lblAnoNasc.Text = "ANO DE NASCIMENTO";
            lblValorBase.Text = "VALOR BASE";
            lblDistrito.Text = "Reside no distrito?";
            lblConcelho.Text = "CONCELHO";
            chkDesc10.Text = "Desconto de escalão? (10%)";
            chkDesc5.Text = "Desconto de sócio? (5%)";
            chkAgrav12.Text = "Tem agravamento? (12€)";
            rdbSim.Text = "Sim";
            rdbNao.Text = "Não";
            picShreck.Load("https://steamuserimages-a.akamaihd.net/ugc/285225308508782583/ACF1F2CCC07EF721673F913C9848ECD84D147E4F/?imw=5000&imh=5000&ima=fit&impolicy=Letterbox&imcolor=%23000000&letterbox=false");
            picShreck.SizeMode = PictureBoxSizeMode.StretchImage;
            btnCalc.Text = "CALCULAR";
            cbxConcelhos.Items.Add("Braga");
            cbxConcelhos.Items.Add("Amares");
            cbxConcelhos.Items.Add("Guimarães");
            txtValorBase.Text = "100";
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double descontos = 0;
            double resultado = Convert.ToInt64(txtValorBase.Text);
            double valorbase = Convert.ToInt64(txtValorBase.Text);

            if (Convert.ToInt32(txtAnoNasc.Text) >= 2000)
            {
                descontos += valorbase * 0.1;
            }

            if (chkDesc10.Checked)
            {
                descontos += valorbase * 0.1;
            }

            if (chkDesc5.Checked)
            {
                descontos += valorbase * 0.05;
            }

            if (chkAgrav12.Checked)
            {
                descontos -= 12;
            }

            if (rdbSim.Checked)
            {
                descontos += valorbase * 0.01;
            }

            if (cbxConcelhos.Text == "Amares")
            {
                descontos += valorbase * 0.2;
            }

            resultado -= descontos;
            txtResultado.Text = Convert.ToString(resultado);
        }
    }
}
