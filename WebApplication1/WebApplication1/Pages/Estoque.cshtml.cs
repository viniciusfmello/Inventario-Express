using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;
using WebApplication1.Entities;

namespace WebApplication1.Pages
{
    public class EstoqueModel : PageModel

    {
        [BindProperty]
        public int totalProdutos { get; set; }
        [BindProperty]
        public double totalPreco { get; set; }
        public void OnGet()
        {
            Database bancoDeDados = new Database();
            SqlDataReader leitor;

            totalProdutos = Auxiliar.GetAtualId("tb_produto");
            totalPreco = Auxiliar.GetPrecoTotal("tb_produto");
        }
    }
}
