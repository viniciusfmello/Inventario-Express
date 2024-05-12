using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WebApplication1.Entities
{
    public class Fornecedor
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public Fornecedor(string nome, string descricao)
        {
            Nome = nome;
            Descricao = descricao;
        }
    }
}
