using System.Data.SqlClient;
using System.Linq;
using System.Collections.Generic;

namespace WebScraping
{ 
    public class ConexaoDB 
    {
        SqlConnection conexao = new SqlConnection();
        
        public ConexaoDB() 
        {
            // Colocar a conexão com o seu banco de dados seja local ou servidor
            conexao.ConnectionString = "";
        }

        public SqlConnection conectar()
        {
            if(conexao.State == System.Data.ConnectionState.Closed)
            {
                conexao.Open();
            }

            return conexao;
        }

        public void desconectar() 
        {
            if (conexao.State == System.Data.ConnectionState.Open)
            {
                conexao.Close();
            }
        }
    }

}
