using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Entities;

namespace WebApplication1.Pages
{
    public class ExcluirProdutoModel : PageModel
    {
        

        [BindProperty]
        public string Quantidade { get; set; }
        public IActionResult OnGet(int id)
        {
            if (!LoginuserModel.isUsuarioLogado)
            {
                return RedirectToPage("/Loginuser");
            }
            Auxiliar.deleteProduto(id);
            return RedirectToPage("/Estoque");


        }
        /*
        public IActionResult OnPostRemove()
        {

            Auxiliar.deleteProduto(Id);
            return RedirectToPage("/Index");
        }
        public IActionResult OnPostCancela()
        {
            return RedirectToPage("/Estoque");
        }*/

    }
}
