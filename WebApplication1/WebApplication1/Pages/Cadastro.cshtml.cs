using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
using System.Drawing;
using WebApplication1.Entities;

namespace WebApplication1.Pages
{
    public class CadastroModel : PageModel
    {

        [BindProperty]
        public string Nome { get; set; }
        [BindProperty]

        public int Quantidade { get; set; }
        [BindProperty]

        public string Data { get; set; }
        [BindProperty]
        public string Descricao { get; set; }
        [BindProperty]
        public string Preco { get; set; }
        [BindProperty]
        public string Fornecedor { get; set; }

        [BindProperty]
        public List<Fornecedor> ListaFornecedores { get; set; }

        public IActionResult OnGet()
        {
            if (!LoginuserModel.isUsuarioLogado)
            {
                return RedirectToPage("/Loginuser");
            }

            ListaFornecedores = Auxiliar.GetListaDeFornecedor();
            return Page();
        }
        public IActionResult OnPost()
        {
            Database bancoDeDados = new Database();
            SqlDataReader leitor;

            Produto produto = new Produto(Nome,Data,Descricao,Preco,Fornecedor);

            string query = $"insert into tb_produto (id, nome, Quantidade, data_validade, descricao, preco, nome_fornecedor) values " +
                $"({produto.Id}, '{Nome}', '{Quantidade}', '{Data}', '{Descricao}', '{Preco}', '{Fornecedor}')";

            bancoDeDados.manipularDado(query);


            return RedirectToPage("/Cadastro");
        }
    }
}
