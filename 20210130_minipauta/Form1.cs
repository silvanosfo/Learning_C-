using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace _20210130_minipauta
{
    public struct ficha
    { //declarar cada membro com o "âmbito" public + respetivo tipo:
        public int numero;
        public string nome;
        public string freguesia;
        public int ano;
        public char sexo;
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            btnRaparigas.Text = "Conta Rarigas";
            btnRapazes.Text = "Conta Rapazes";
            btnMaiorSexo.Text = "Qual o género em maioria?";
            btnMaisVelho.Text = "Qual a pessoa mais velha?";
            btnReprov12.Text = "Nº reprovados com média >=12";
            btn3Melhores.Text = "3 Melhores";
            btnApelRep.Text = "Apelidos Reprovados";
            CriarColunas();
            //ColonizarGridA();
            //ColonizarGridB();
            ColonizarGridC();
            CalcularMedia();
            ContarNegativas();
        }
        public void CriarColunas()
        {
            dgvPauta.Columns.Add("num", "Nº");
            dgvPauta.Columns.Add("nome", "NOME");
            dgvPauta.Columns.Add("local", "FREGUESIA");
            dgvPauta.Columns.Add("anonasc", "Ano");
            dgvPauta.Columns.Add("sexo", "Sexo");
            dgvPauta.Columns.Add("por", "POR");
            dgvPauta.Columns.Add("ing", "ING");
            dgvPauta.Columns.Add("fil", "FIL");
            dgvPauta.Columns.Add("mat", "MAT");
            dgvPauta.Columns.Add("fis", "FÍS");
            dgvPauta.Columns.Add("qui", "QUÍ");
            dgvPauta.Columns.Add("geo", "GEO");
            dgvPauta.Columns.Add("his", "HIS");
            dgvPauta.Columns.Add("ef", "EF");
            dgvPauta.Columns.Add("mor", "MOR");
            dgvPauta.Columns.Add("media", "Média");
            dgvPauta.Columns.Add("neg", "Negat.");
        }
        public void ColonizarGridC()
        {
            ficha[] arrayDeFormandos = new ficha[20];//array de 20 fichas
            InitArrayOfFicha(ref arrayDeFormandos);
            int[,] matrizDeNotas = new int[20, 10]; //matrix de 20x10 inteiros
            InitMatriz(ref matrizDeNotas);
        }
        public void InitArrayOfFicha(ref ficha[] A)
        {
            A[0].numero = 1; A[0].nome = "Ana Rita Cunha"; A[0].freguesia = "Gualtar"; A[0].ano = 1997; A[0].sexo = 'F';
            A[1].numero = 2; A[1].nome = "Bela Costa Silva"; A[1].freguesia = "Maximinos"; A[1].ano = 1999; A[1].sexo = 'F';
            A[2].numero = 3; A[2].nome = "Carlos Alberto Costa"; A[2].freguesia = "Aveleda"; A[2].ano = 2000; A[2].sexo = 'M';
            A[3].numero = 4; A[3].nome = "Carlos Daniel Ferreira"; A[3].freguesia = "Gualtar"; A[3].ano = 2000; A[3].sexo = 'M';
            A[4].numero = 5; A[4].nome = "Daniel Bastos Gomes"; A[4].freguesia = "Maximinos"; A[4].ano = 2001; A[4].sexo = 'M';
            A[5].numero = 6; A[5].nome = "Daniel Silva Ferraz"; A[5].freguesia = "Ferreiros"; A[5].ano = 1997; A[5].sexo = 'M';
            A[6].numero = 7; A[6].nome = "Elvira Gomes Pendes"; A[6].freguesia = "Maximinos"; A[6].ano = 2002; A[6].sexo = 'F';
            A[7].numero = 8; A[7].nome = "Fernanda Maria Silva"; A[7].freguesia = "Aveleda"; A[7].ano = 2001; A[7].sexo = 'F';
            A[8].numero = 9; A[8].nome = "Fernando Gomes Barros"; A[8].freguesia = "Gualtar"; A[8].ano = 1997; A[8].sexo = 'M';
            A[9].numero = 10; A[9].nome = "Guilherme Alexandre Barros"; A[9].freguesia = "Aveleda"; A[9].ano = 1997; A[9].sexo = 'M';
            A[10].numero = 11; A[10].nome = "Hilda Fonseca Silva"; A[10].freguesia = "Maximinos"; A[10].ano = 1997; A[10].sexo = 'F';
            A[11].numero = 12; A[11].nome = "José Manuel Carvalho"; A[11].freguesia = "Sé"; A[11].ano = 2001; A[11].sexo = 'M';
            A[12].numero = 13; A[12].nome = "José Alberto Gomes"; A[12].freguesia = "Maximinos"; A[12].ano = 2002; A[12].sexo = 'M';
            A[13].numero = 14; A[13].nome = "Maria Silvéria Bastos"; A[13].freguesia = "Lovios"; A[13].ano = 2001; A[13].sexo = 'F';
            A[14].numero = 15; A[14].nome = "Anabela Bastos Torres"; A[14].freguesia = "Ferreiros"; A[14].ano = 1997; A[14].sexo = 'F';
            A[15].numero = 16; A[15].nome = "Rui Vasco Santos"; A[15].freguesia = "Maximinos"; A[15].ano = 2001; A[15].sexo = 'M';
            A[16].numero = 17; A[16].nome = "Otávio Ferreira"; A[16].freguesia = "Gualtar"; A[16].ano = 2002; A[16].sexo = 'M';
            A[17].numero = 18; A[17].nome = "Silvério Silva Teixeira"; A[17].freguesia = "Ferreiros"; A[17].ano = 1997; A[17].sexo = 'M';
            A[18].numero = 19; A[18].nome = "Teodoro Armando Matos"; A[18].freguesia = "Maximinos"; A[18].ano = 2004; A[18].sexo = 'M';
            A[19].numero = 20; A[19].nome = "Zacarias Alexandre Sampaio"; A[19].freguesia = "Sequeira"; A[19].ano = 1995; A[19].sexo = 'M';

            for (int i = 0; i < 20; i++)
            {
                dgvPauta.Rows.Add(A[i].numero, A[i].nome, A[i].freguesia, A[i].ano, A[i].sexo);
            }
        }
        public void InitMatriz(ref int[,] m)
        {
            int fator = 1000000;//modificar este valor se a geração ficar lenta

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    for (int k = 0; k < fator; k++)
                    {
                        //diversão ao processador, 
                        //para melhorar a geração de aleatórios
                    }
                    m[i, j] = GeraValor();
                }
            }

            for (int i = 0; i < dgvPauta.Rows.Count - 1; i++)
            {
                for (int j = 5; j < 15; j++)
                {
                    dgvPauta.Rows[i].Cells[j].Value = m[i, j-5];
                }
            }
        }
        private int GeraValor()
        {   //devolve valor entre 6 e 20
            int avaliacao;
            Random r = new Random();

            avaliacao = r.Next(6, 21);
            //reduzir, mas não impossibilitar, a ocorrência de negativas e de valores acima de 18:
            if (avaliacao < 10 || avaliacao > 18) { avaliacao = r.Next(6, 21); }
            return avaliacao;
        }
        private void ColonizarGridA()
        {
            dgvPauta.Rows.Add("1", "Ana", "Mazagão", "1996", "F");
            dgvPauta.Rows.Add("2", "Paulo", "Ferreiros", "1994", "M");
        }
        private void ColonizarGridB()
        {
            dgvPauta.Rows.Add("1", "Ana Rita Cunha", "Gualtar", "1997", 'F', "10", "11", "12", "10", "11", "12", "10", "11", "12", "11", "--", "--");
            dgvPauta.Rows.Add("2", "Bela Costa Silva", "Maximinos", "1999", "F", "15", "11", "12", "10", "11", "12", "10", "11", "12", "8", "--", "--");
            dgvPauta.Rows.Add("3", "Carlos Alberto Costa", "Aveleda", "2000", "M", "10", "11", "12", "10", "11", "12", "10", "19", "12", "12", "--", "--");
            dgvPauta.Rows.Add("4", "Carlos Daniel Ferreira", "Gualtar", "2000", "M", "10", "11", "12", "10", "11", "12", "10", "11", "12", "8", "--", "--");
            dgvPauta.Rows.Add("5", "Daniel Bastos Gomes", "Maximinos", "2001", "M", "10", "11", "8", "10", "11", "12", "10", "11", "12", "18", "--", "--");
            dgvPauta.Rows.Add("6", "Daniel Silva Ferraz", "Ferreiros", "1997", "M", "9", "11", "12", "10", "11", "12", "7", "11", "12", "8", "--", "--");
            dgvPauta.Rows.Add("7", "Elvira Gomes Pendes", "Maximinos", "2002", "F", "10", "11", "12", "10", "11", "12", "10", "11", "12", "13", "--", "--");
            dgvPauta.Rows.Add("8", "Fernanda Maria Silva", "Aveleda", "2001", "F", "10", "11", "12", "10", "11", "12", "10", "11", "12", "8", "--", "--");
            dgvPauta.Rows.Add("9", "Fernando Gomes Barros", "Gualtar", "1997", "M", "7", "11", "12", "10", "9", "12", "10", "11", "12", "16", "--", "--");
            dgvPauta.Rows.Add("10", "Guilherme Alexandre Barros", "Aveleda", "1997", "M", "10", "11", "19", "10", "11", "12", "10", "11", "12", "8", "--", "--");
            dgvPauta.Rows.Add("11", "Hilda Fonseca Silva", "Maximinos", "1997", "F", "10", "11", "12", "10", "11", "12", "10", "11", "12", "13", "--", "--");
            dgvPauta.Rows.Add("12", "José Manuel Carvalho", "Sé", "2001", "M", "10", "11", "16", "10", "11", "12", "10", "11", "12", "13", "--", "--");
            dgvPauta.Rows.Add("13", "José Alberto Gomes", "Maximinos", "2002", "M", "10", "11", "12", "10", "11", "12", "10", "11", "12", "8", "--", "--");
            dgvPauta.Rows.Add("14", "Maria Silvéria Bastos", "Lovios", "2001", "F", "10", "11", "12", "16", "11", "12", "10", "11", "12", "8", "--", "--");
            dgvPauta.Rows.Add("15", "Anabela Bastos Torres", "Ferreiros", "1997", "F", "10", "11", "12", "10", "11", "12", "10", "11", "12", "14", "--", "--");
            dgvPauta.Rows.Add("16", "Rui Vasco Santos", "Maximinos", "2001", "M", "10", "11", "12", "10", "15", "12", "10", "11", "12", "5", "--", "--");
            dgvPauta.Rows.Add("17", "Otávio Ferreira", "Gualtar", "2002", "M", "10", "11", "12", "10", "11", "12", "10", "11", "12", "8", "--", "--");
            dgvPauta.Rows.Add("18", "Silvério Silva Teixeira", "Ferreiros", "1997", "M", "10", "11", "12", "10", "11", "12", "10", "11", "12", "8", "--", "--");
            dgvPauta.Rows.Add("19", "Teodoro Armando Matos", "Maximinos", "2004", "M", "10", "11", "12", "10", "11", "12", "10", "11", "12", "8", "--", "--");
            dgvPauta.Rows.Add("20", "Zacarias Alexandre Sampaio", "Sequeira", "1995", "M", "10", "11", "12", "10", "11", "12", "10", "11", "12", "8", "--", "--");
        }
        private void CalcularMedia()
        {
            double media, soma = 0;

            for (int i = 0; i < dgvPauta.Rows.Count - 1; i++)
            {
                for (int j = 5; j < 15; j++)
                {
                    soma += Convert.ToInt64(dgvPauta.Rows[i].Cells[j].Value);
                }
                media = soma / 10;
                dgvPauta.Rows[i].Cells[15].Value = media; //Atribui valor à coluna média
                soma = 0; //Reset da soma para o próximo ciclo
            }
        }
        private void ContarNegativas()
        {
            int contadorneg = 0;

            for (int i = 0; i < dgvPauta.Rows.Count - 1; i++)
            {
                for (int j = 5; j < 15; j++)
                {
                    if (Convert.ToInt32(dgvPauta.Rows[i].Cells[j].Value) < 10)
                    {
                        contadorneg++;
                    }
                }
                dgvPauta.Rows[i].Cells[16].Value = contadorneg; //Atribui valor à coluna negativas

                //Formata linha se tiver 3 negativas
                if (contadorneg >= 3)
                {
                    dgvPauta.Rows[i].DefaultCellStyle.BackColor = Color.Aqua;
                }

                contadorneg = 0; //Reset do contador para o próximo ciclo
            }
        }
        private void btnRaparigas_Click(object sender, EventArgs e)
        {
            int contagajas = 0;
            for (int i = 0; i < dgvPauta.Rows.Count - 1; i++)
            {
                if (Convert.ToString(dgvPauta.Rows[i].Cells[4].Value) == "F")
                {
                    contagajas++;
                }
            }
            MessageBox.Show("Há " + contagajas + " raparigas");
        }
        private void btnRapazes_Click(object sender, EventArgs e)
        {
            int contagajos = 0;
            for (int i = 0; i < dgvPauta.Rows.Count - 1; i++)
            {
                if (Convert.ToString(dgvPauta.Rows[i].Cells[4].Value) == "M" && Convert.ToString(dgvPauta.Rows[i].Cells[2].Value) == "Maximinos")
                {
                    contagajos++;
                }
            }
            MessageBox.Show("Há " + contagajos + " rapazes");
        }
        private void btnMaiorSexo_Click(object sender, EventArgs e)
        {
            int contaF = 0;
            int contaM = 0;

            for (int i = 0; i < dgvPauta.Rows.Count - 1; i++)
            {
                if (Convert.ToString(dgvPauta.Rows[i].Cells[4].Value) == "F")
                {
                    contaF++;
                }
                else
                {
                    contaM++;
                }
            }

            if (contaF > contaM) 
            {
                MessageBox.Show("As raparigas estão em maioria");
            }
            else
            {
                MessageBox.Show("As rapazes estão em maioria");
            }
        }
        private void btnMaisVelho_Click(object sender, EventArgs e)
        {
            int maisvelho = Convert.ToInt32(dgvPauta.Rows[0].Cells[3].Value);
            int p = 0;
            for (int i = 0; i < dgvPauta.Rows.Count - 1; i++)
            {
                if (maisvelho > Convert.ToInt32(dgvPauta.Rows[i].Cells[3].Value))
                {
                    maisvelho = Convert.ToInt32(dgvPauta.Rows[i].Cells[3].Value);
                    p = i;
                }
            }
            MessageBox.Show(Convert.ToString(dgvPauta.Rows[p].Cells[1].Value));
        }
        private void btnReprov12_Click(object sender, EventArgs e)
        {
            int contador = 0;
            for (int i = 0; i < dgvPauta.Rows.Count - 1; i++)
            {
                if (Convert.ToDouble(dgvPauta.Rows[i].Cells[15].Value) > 12 && Convert.ToInt32(dgvPauta.Rows[i].Cells[16].Value) >= 3)
                {
                    contador++;
                }
            }
            MessageBox.Show("Existem " + contador + " alunos reprovados com média >12");
        }
        private void btn3Melhores_Click(object sender, EventArgs e)
        {
            double media1 = 0;
            double media2 = 0;
            double media3 = 0;
            string p1 = "-", p2 = "-", p3 = "-";

            for (int i = 0; i < dgvPauta.Rows.Count - 1; i++)
            {
                if (Convert.ToInt32(dgvPauta.Rows[i].Cells[16].Value) < 3 && media1 < Convert.ToDouble(dgvPauta.Rows[i].Cells[15].Value))
                {
                    media1 = Convert.ToDouble(dgvPauta.Rows[i].Cells[15].Value);
                    p1 = Convert.ToString(dgvPauta.Rows[i].Cells[1].Value);
                }
            }
            for (int i = 0; i < dgvPauta.Rows.Count - 1; i++)
            {
                if (Convert.ToInt32(dgvPauta.Rows[i].Cells[16].Value) < 3 && Convert.ToDouble(dgvPauta.Rows[i].Cells[15].Value) < media1 )
                {
                    if (media2 < Convert.ToDouble(dgvPauta.Rows[i].Cells[15].Value))
                    {
                        media2 = Convert.ToDouble(dgvPauta.Rows[i].Cells[15].Value);
                        p2 = Convert.ToString(dgvPauta.Rows[i].Cells[1].Value);
                    }
                }
            }
            for (int i = 0; i < dgvPauta.Rows.Count - 1; i++)
            {
                if (Convert.ToInt32(dgvPauta.Rows[i].Cells[16].Value) < 3 && Convert.ToDouble(dgvPauta.Rows[i].Cells[15].Value) < media2)
                {
                    if (media3 < Convert.ToDouble(dgvPauta.Rows[i].Cells[15].Value))
                    {
                        media3 = Convert.ToDouble(dgvPauta.Rows[i].Cells[15].Value);
                        p3 = Convert.ToString(dgvPauta.Rows[i].Cells[1].Value);
                    }
                }
            }
            MessageBox.Show("Ranking de alunos:" +
                            "\n1 - " + p1 + 
                            "\n2 - " + p2 + 
                            "\n3 - " + p3);
        }
        private void btnApelRep_Click(object sender, EventArgs e)
        {
            List<string> apelidos = new List<string>();
            int pos = 0;

            for (int i = 0; i < dgvPauta.Rows.Count - 1; i++)
            {
                if (Convert.ToInt32(dgvPauta.Rows[i].Cells[16].Value) >= 3)
                {
                    for (int j = Convert.ToString(dgvPauta.Rows[i].Cells[1].Value).Length - 1; j > 0; j--)
                    {
                        if (Convert.ToString(dgvPauta.Rows[i].Cells[1].Value)[j] == ' ')
                        {
                            pos = j;
                            break;
                            //for (int k = j; k < Convert.ToString(dgvPauta.Rows[i].Cells[1].Value).Length - 1; k++)
                            //{
                            //    apelidos[q] = apelidos[q] + Convert.ToString(dgvPauta.Rows[i].Cells[1].Value)[k];
                            //}
                        }
                        apelidos.Add(Convert.ToString(dgvPauta.Rows[i].Cells[1].Value).Substring(pos));
                    }
                }
            }
            MessageBox.Show(apelidos[0]);
        }
    }
}
