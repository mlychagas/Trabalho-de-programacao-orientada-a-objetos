using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace backfazenda.utilitario
{
    internal class Conexao
    {
        static MySqlConnection conexao;
        public static MySqlConnection Conectar()
        {
            try
            {
                string varconexao = "server = localhost; uid=" +
                "root; pwd= r00t; port=3306; database = Fazenda";
                conexao = new MySqlConnection(varconexao);
                conexao.Open();
                return conexao;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }
        public static void FecharConexao()
        {
            conexao.Close();
        }

    }
}
