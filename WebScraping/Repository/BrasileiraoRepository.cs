using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WebScraping
{
    public class BrasileiraoRepository
    {
        ConexaoDB conexao = new ConexaoDB();
        SqlCommand cmd = new SqlCommand();

        public void registrarTimes(List<Brasileirao> br) 
        {
            try 
            {
                cmd.Connection = conexao.conectar();
                
                cmd.CommandText = "DELETE dbo.Brasileirao";
                cmd.ExecuteNonQuery();
                
                foreach (var time in br)
                {
                    cmd.CommandText = "INSERT INTO Brasileirao (Posicao, Time, Pontos) values(@Posicao" + time.posicao + ", @Time" + time.posicao + ", @Pontos" + time.posicao + ")";

                    cmd.Parameters.AddWithValue("@Posicao" + time.posicao, time.posicao);
                    cmd.Parameters.AddWithValue("@Time" + time.posicao, time.nome);
                    cmd.Parameters.AddWithValue("@Pontos" + time.posicao, time.pontos);
                    cmd.ExecuteNonQuery();
                }

                conexao.desconectar();
            }
            catch(Exception ex) 
            {
                Console.WriteLine("Error: {0}", ex);
            }
        }
    }
}
