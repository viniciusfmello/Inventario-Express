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
        public List<Produto> listaProdutos { get; set; }
        public IActionResult OnGet()
        {
            if (!LoginuserModel.isUsuarioLogado)
            {
                return RedirectToPage("/Loginuser");
            }
            listaProdutos = Auxiliar.GetListaDeProdutos();
            
            
            return Page();

        }
    }
}
