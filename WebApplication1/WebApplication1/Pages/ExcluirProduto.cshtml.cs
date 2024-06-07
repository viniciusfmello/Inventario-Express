using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Entities;

namespace WebApplication1.Pages
{
    public class ExcluirProdutoModel : PageModel
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
            //Auxiliar.deleteProduto(id);


        }
        
        public IActionResult OnPost(int id)
        {

            Auxiliar.deleteProduto(id, Quantidade);
            return RedirectToPage("/Estoque");
        }


    }
}
