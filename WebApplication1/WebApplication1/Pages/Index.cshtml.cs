using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Entities;

namespace WebApplication1.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public int totalProdutos { get; set; }
        [BindProperty]
        public double totalPreco { get; set; }


        [BindProperty]
        public List<Produto> listaProdutos { get; set; }

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public IActionResult OnGet()
        {

            if (!LoginuserModel.isUsuarioLogado)
{
                return RedirectToPage("/Loginuser");
            }
            totalProdutos = Auxiliar.GetAtualId("tb_produto");
            totalPreco =0;

            listaProdutos = Auxiliar.GetListaDeProdutos();

            for(int i = 0 ; i < listaProdutos.Count ; i++)
            {
                totalPreco += Convert.ToDouble(listaProdutos[i].Preco) * listaProdutos[i].Quantidade;
            }
            totalPreco = Math.Round(totalPreco, 2,  MidpointRounding.AwayFromZero);

            return Page();
        }
    }
}
