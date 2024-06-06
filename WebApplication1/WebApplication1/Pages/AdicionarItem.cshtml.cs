using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Identity.Client;
using WebApplication1.Entities;

namespace WebApplication1.Pages
{
    public class AdicionarItemModel : PageModel
    {
        [BindProperty]
        public int Quantidade { get; set; }

        public IActionResult OnGet(int id)
        {
            if (!LoginuserModel.isUsuarioLogado)
            {
                return RedirectToPage("/Loginuser");
            }
            return Page();
        }

        public IActionResult OnPost(int Id)
        {
            Auxiliar.addProduto(Id, Quantidade);

            return RedirectToPage("/Estoque");
        }
    }
}
