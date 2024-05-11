using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;
using WebApplication1.Entities;

namespace WebApplication1.Pages
{
 
    public class LoginuserModel : PageModel
    {
        public static bool isUsuarioLogado=false;

        [BindProperty]
        public string Usuario { get; set; }
        [BindProperty]
        public string Senha { get; set; }

        public string mensagemErro; 
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            bool validacao = Auxiliar.isValidLogin(Usuario , Senha);
            if (validacao)
            {
                isUsuarioLogado = true;
                mensagemErro= "";
                return RedirectToPage("/Index");
            }
            else
            {
                mensagemErro = "Usuário ou senha incorretos!";
                return Page();
                //return RedirectToPage("/Loginuser");
            }
            
        }
    }
}
