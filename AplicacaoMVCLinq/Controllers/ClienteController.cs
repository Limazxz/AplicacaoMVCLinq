using AplicacaoMVCLinq.Models;
using Microsoft.AspNetCore.Mvc;

namespace AplicacaoMVCLinq.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetCliente()
        {
            Cliente c1 = new Cliente(1, "Pedro Lima", "silvaelima@gmail.com", "1499662", new DateOnly(2000, 3, 17));
            Cliente c2 = new Cliente(2, "Mike", "mikeon@gmail.com", "1499661", new DateOnly(2001, 3, 21));
            Cliente c3 = new Cliente(3, "Jhonatan", "jhontan34@gmail.com", "1499664", new DateOnly(2002, 3, 20));
            Cliente c4 = new Cliente(4, "Steven", "stven675@gmail.com", "1499663", new DateOnly(2003, 8, 11));
            Cliente c5 = new Cliente(5, "Robertson", "robertson456@gmail.com", "1499669", new DateOnly(2004, 10, 11));

            List<Cliente> listaCliente = new List<Cliente>();
            listaCliente.Add(c1);
            listaCliente.Add(c2);
            listaCliente.Add(c3);
            listaCliente.Add(c4);
            listaCliente.Add(c5);


            return View(listaCliente);
        }
    }
}
