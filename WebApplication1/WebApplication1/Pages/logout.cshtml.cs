using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class logoutModel : PageModel
    {
        public IActionResult OnGet()
        {
            LoginuserModel.isUsuarioLogado = false;
            return RedirectToPage("/Loginuser");
        }
    }
}
