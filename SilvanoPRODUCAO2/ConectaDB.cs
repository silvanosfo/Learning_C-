using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassConectaDB
        
{
    public class ConectaDB
    {
        private static string strConn = "data source = **.**.**.***,*****;Initial Catalog = SilvanoPROD2CS;User Id=EFASilvano;Password = SILvanosfo;";
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
}
