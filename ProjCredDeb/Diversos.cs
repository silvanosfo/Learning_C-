using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;

namespace Diversos 
{
    public class Conecta
    {
        public static string strConn = "data source = **.**.**.***,*****;Initial Catalog = zSilCredDeb;User Id=EFASilvano;Password = SILvanosfo;";
        public string strSQL;
        public DataTable BuscarDados()
        {
            //criar uma conexão:
            SqlConnection C = new SqlConnection(strConn);
            C.Open();
            //criar comando SQL para extrair os dados pretendidos:
            SqlCommand command = C.CreateCommand();
            command.CommandText = strSQL;

            //trazer os dados da tabela especificada para uma "tabela" em memória:
            SqlDataAdapter da = new SqlDataAdapter(command);
            var dt = new DataTable();
            da.Fill(dt);

            //desligar a conexão:
            C.Close();
            return dt;
        }
    }

    public class FormatarGrid
    {
        public void Reset (DataGridView dgv)
        {

        }

        public void Formatar(DataGridView dgvMovimentos)
        {
            dgvMovimentos.AllowUserToAddRows = false;
            dgvMovimentos.ColumnHeadersVisible = true;
            dgvMovimentos.RowHeadersVisible = false;

            //id:
            dgvMovimentos.Columns[0].Name = "id";
            dgvMovimentos.Columns[0].HeaderText = "PK";
            dgvMovimentos.Columns["id"].Visible = false;
            dgvMovimentos.Columns["id"].Width = 30;

            //data
            dgvMovimentos.Columns[1].Name = "data"; dgvMovimentos.Columns[1].HeaderText = "Data";
            dgvMovimentos.Columns["data"].Visible = true; dgvMovimentos.Columns["data"].Width = 80;
            dgvMovimentos.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //descricao:
            dgvMovimentos.Columns[2].Name = "descricao"; dgvMovimentos.Columns[2].HeaderText = "Descrição";
            dgvMovimentos.Columns["descricao"].Visible = true; dgvMovimentos.Columns["descricao"].Width = 300;
            for (int i = 0; i < dgvMovimentos.RowCount; i++)
            { 
                dgvMovimentos.Rows[i].Cells[2].Style.Font = new Font("Arial", 8, FontStyle.Bold); 
            }

            //valorCredito
            dgvMovimentos.Columns[3].Name = "credito"; dgvMovimentos.Columns[3].HeaderText = "Valor Crédito";
            dgvMovimentos.Columns["credito"].Visible = true; dgvMovimentos.Columns["credito"].Width = 80;
            dgvMovimentos.Columns[3].DefaultCellStyle.Format = "c2";
            //for (int i = 0; i < dgvMovimentos.RowCount; i++) {dgvMovimentos.Rows[i].Cells[3].Style.Format = "0.00";} funciona
            dgvMovimentos.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            //valorDebito:
            dgvMovimentos.Columns[4].Name = "debito"; dgvMovimentos.Columns[4].HeaderText = "Valor Débito";
            dgvMovimentos.Columns["debito"].Visible = true; dgvMovimentos.Columns["debito"].Width = 80;
            dgvMovimentos.Columns[4].DefaultCellStyle.Format = "c2";
            // for (int i = 0; i < dgvMovimentos.RowCount; i++) { dgvMovimentos.Rows[i].Cells[4].Style.Format = "0.00"; }//funciona
            dgvMovimentos.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            //saldo
            dgvMovimentos.Columns[5].Name = "saldo"; dgvMovimentos.Columns[5].HeaderText = "Saldo";
            dgvMovimentos.Columns["saldo"].Visible = true; dgvMovimentos.Columns["saldo"].Width = 100;
            //dgvMovimentos.Columns[5].DefaultCellStyle.Format = "# ##0.00";//funciona
            dgvMovimentos.Columns[5].DefaultCellStyle.Format = "c2";
            dgvMovimentos.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvMovimentos.Columns["saldo"].ReadOnly = true;//proteger contra alteração pelo utilizador
            dgvMovimentos.Columns["saldo"].DefaultCellStyle.ForeColor = Color.Navy;
            dgvMovimentos.Columns["saldo"].DefaultCellStyle.BackColor = Color.Lavender;

            //Está ordenado em SQL
            /*dgvMovimentos.Sort(dgvMovimentos.Columns["data"], ListSortDirection.Ascending);

            try
            {//mostrar sempre os últimos registos da grid:
                dgvMovimentos.FirstDisplayedScrollingRowIndex = dgvMovimentos.RowCount - 1;
            }
            catch (Exception)
            {
                ;

            }*/
        }
    }
}
