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
            totalPreco = Auxiliar.GetPrecoTotal("tb_produto");
            return Page();

        }
    }
}
