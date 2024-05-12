using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace WebApplication1.Entities
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Data { get; set; }
        public string Descricao { get; set; }
        public string Preco { get; set; }
        public string Fornecedor { get; set; }

        public Produto(string nome, string data, string descricao, string preco, string fornecedor)
        {
            Nome = nome;
            Data = data;
            Descricao = descricao;
            Preco = preco;
            Fornecedor = fornecedor;
            Id = Auxiliar.GetProxId("tb_produto");
        }

        public Produto(string nome, string data, string descricao, string preco, string fornecedor, int ID)
        {
            Nome = nome;
            Data = data;
            Descricao = descricao;
            Preco = preco;
            Fornecedor = fornecedor;
            Id = ID;
        }

    }
}
