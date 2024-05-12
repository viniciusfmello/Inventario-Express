using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Entities;

namespace WebApplication1.Pages
{
    public class InfoProdutoModel : PageModel
    {
        public List<Produto> ListaDeProdutosFornecedor;
        public void OnGet(string nome)
        {
            ListaDeProdutosFornecedor = Auxiliar.GetListaDeProdutosFornecedor(nome);
        }
    }
}
