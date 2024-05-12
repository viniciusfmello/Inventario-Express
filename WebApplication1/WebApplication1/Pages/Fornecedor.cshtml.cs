using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Entities;

namespace WebApplication1.Pages
{
    public class FornecedorModel : PageModel
    {
        [BindProperty]
        public List<Fornecedor> listaFornecedor { get; set; }
        public IActionResult OnGet()
        {
            if (!LoginuserModel.isUsuarioLogado)
            {
                return RedirectToPage("/Loginuser");
            }
            listaFornecedor = Auxiliar.GetListaDeFornecedor();


            return Page();
        }
    }
}
