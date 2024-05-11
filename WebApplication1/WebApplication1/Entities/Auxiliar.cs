using Microsoft.Data.SqlClient;

namespace WebApplication1.Entities
{
    static class Auxiliar
    {

        public static int GetAtualId(string tabela)
        {
            Database bancoDeDados = new Database();
            SqlDataReader leitor;
            int id;
            string query = $"select count(id) from {tabela}";
            bancoDeDados.abrirConexao();

            leitor = bancoDeDados.executarQuery(query);

            if (leitor.HasRows)
            {
                leitor.Read();
                id = leitor.GetInt32(0);
            }
            else
            {
                id = 1;
            }
            bancoDeDados.fechar();
            return id;

        }

        public static double GetPrecoTotal(string tabela)
        {
            Database bancoDeDados = new Database();
            SqlDataReader leitor;
            double preco;
            string query = $"select sum(preco) from {tabela}";
            bancoDeDados.abrirConexao();

            leitor = bancoDeDados.executarQuery(query);

            if (leitor.HasRows)
            {
                leitor.Read();
                preco = leitor.GetDouble(0);
            }
            else
            {
                preco = 1;
            }
            bancoDeDados.fechar();
            return preco;

        }
        public static int GetProxId(string tabela)
        {
            Database bancoDeDados = new Database();
            SqlDataReader leitor;
            int id;
            string query = $"select count(id) from {tabela}";
            bancoDeDados.abrirConexao();

            leitor = bancoDeDados.executarQuery(query);

            if (leitor.HasRows)
            {
                leitor.Read();
                id = leitor.GetInt32(0) + 1;
            }
            else
            {
                id = 1;
            }
            bancoDeDados.fechar();
            return id;

        }

        public static bool isValidLogin(string usuario, string senhaInformada)
        {
            Database bancoDeDados = new Database();
            SqlDataReader leitor;
            string senhaBanco;
            string query = $"SELECT senha FROM tb_usuario WHERE usuario_login='{usuario}'";
            
            bancoDeDados.abrirConexao();

            leitor = bancoDeDados.executarQuery(query);

            if (!leitor.HasRows)
            {
                bancoDeDados.fechar();
                return false;
            }

            leitor.Read();
            senhaBanco = leitor.GetString(0);

            if (!senhaBanco.Equals(senhaInformada))
            {
                bancoDeDados.fechar();
                return false;
            }

            bancoDeDados.fechar();
            return true;

        }

    }
}
