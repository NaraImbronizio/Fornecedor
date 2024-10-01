using Microsoft.AspNetCore.Mvc;

public class FornecedorController : Controller
{
    public IActionResult Index()
    {
       
        var fornecedor = new Fornecedor
        {
            Nome = "Magit Tecnologia e Sistemas Ltda",
            Endereco = "Avenida Presidente Vargas, 1280",
            Telefone = "(16) 2138-5678"
        };

        return View(fornecedor);
    }
}
