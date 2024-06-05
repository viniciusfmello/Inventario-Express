using Microsoft.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
            string query = $"select id from {tabela} order by id DESC";
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
        public static List<Produto> GetListaDeProdutos()
        {
            List<Produto> produtos = new List<Produto>();



            Database bancoDeDados = new Database();
            SqlDataReader leitor;
            int totalProdutos = 0;



            bancoDeDados.abrirConexao();

            leitor = bancoDeDados.executarQuery("select count(distinct id) from tb_produto");
            if (leitor.HasRows)
            {
                leitor.Read();
                totalProdutos = leitor.GetInt32(0) + 1;
            }

            bancoDeDados.fechar();

            bancoDeDados.abrirConexao();

            leitor = bancoDeDados.executarQuery("select * from tb_produto");
            int count = 1;
            while (leitor.HasRows)
            {
                if (count != totalProdutos)
                {
                    //Dictionary<string, string> temp_dict = new Dictionary<string, string>();

                    leitor.Read();
                    int id = leitor.GetInt32(0);
                    string nome = leitor.GetString(1);         
                    double valor = leitor.GetDouble(2);
                    string fornecedor = leitor.GetString(3);
                    DateTime data = leitor.GetDateTime(5);
                    string descricao = leitor.GetString(6);
                    int quantidade = leitor.GetInt32(7);


                    Produto temp_produto = new Produto(nome, data.ToString(),descricao, valor.ToString(), fornecedor, id, quantidade);


                    produtos.Add(temp_produto);
                    count++;
                }
                else
                {
                    break;
                }
            }
            bancoDeDados.fechar();

            return produtos;


        }

        public static List<Produto> GetListaDeProdutosFornecedor(string nomeFornecedor)
        {
            List<Produto> produtos = new List<Produto>();



            Database bancoDeDados = new Database();
            SqlDataReader leitor;
            int totalProdutos = 0;



            bancoDeDados.abrirConexao();

            leitor = bancoDeDados.executarQuery($"select count(distinct id) from tb_produto where nome_fornecedor='{nomeFornecedor}'");
            if (leitor.HasRows)
            {
                leitor.Read();
                totalProdutos = leitor.GetInt32(0) + 1;
            }

            bancoDeDados.fechar();

            bancoDeDados.abrirConexao();

            leitor = bancoDeDados.executarQuery($"select * from tb_produto where nome_fornecedor='{nomeFornecedor}'");
            int count = 1;
            while (leitor.HasRows)
            {
                if (count != totalProdutos)
                {
                    //Dictionary<string, string> temp_dict = new Dictionary<string, string>();

                    leitor.Read();
                    int id = leitor.GetInt32(0);
                    string nome = leitor.GetString(1);
                    double valor = leitor.GetDouble(2);
                    string fornecedor = leitor.GetString(3);
                    DateTime data = leitor.GetDateTime(5).Date;
                    string descricao = leitor.GetString(6);


                    Produto temp_produto = new Produto(nome, data.ToString(), descricao, valor.ToString(), fornecedor, id);


                    produtos.Add(temp_produto);
                    count++;
                }
                else
                {
                    break;
                }
            }
            bancoDeDados.fechar();

            return produtos;


        }

        public static List<Fornecedor> GetListaDeFornecedor()
        {
            List<Fornecedor> fornecedores = new List<Fornecedor>();



            Database bancoDeDados = new Database();
            SqlDataReader leitor;
            int totalProdutos = 0;



            bancoDeDados.abrirConexao();

            leitor = bancoDeDados.executarQuery("select count(distinct nome) from tb_fornecedor");
            if (leitor.HasRows)
            {
                leitor.Read();
                totalProdutos = leitor.GetInt32(0) + 1;
            }

            bancoDeDados.fechar();

            bancoDeDados.abrirConexao();

            leitor = bancoDeDados.executarQuery("select * from tb_fornecedor");
            int count = 1;
            while (leitor.HasRows)
            {
                if (count != totalProdutos)
                {
                    //Dictionary<string, string> temp_dict = new Dictionary<string, string>();

                    leitor.Read();
                    string nome = leitor.GetString(0);
                    string descricao = leitor.GetString(1);

                    Fornecedor temp_fornecedor = new Fornecedor(nome, descricao);


                    fornecedores.Add(temp_fornecedor);
                    count++;
                }
                else
                {
                    break;
                }
            }
            bancoDeDados.fechar();
            return fornecedores;

        }

        public static void deleteProduto(int id)
        {
            Database bancoDeDados = new Database();
            SqlDataReader leitor;


            string query = $"DELETE from tb_produto WHERE id='{id}'";

            bancoDeDados.manipularDado(query);

        }

    }
}
