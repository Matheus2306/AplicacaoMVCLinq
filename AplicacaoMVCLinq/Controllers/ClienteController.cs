using AplicacaoMVCLinq.Models;
using Microsoft.AspNetCore.Mvc;
using static AplicacaoMVCLinq.Models.Cliente;

namespace AplicacaoMVCLinq.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetClientes()
        {
            Cliente C1 = new Cliente(1, "Alice", "alice@gmail.com", "1234-5678 ", new DateOnly(2000, 6, 1));
            Cliente C2 = new Cliente(2, "Claudio", "Claudio@gmail.com", "2234-5678 ", new DateOnly(1999, 7, 21));
            Cliente C3 = new Cliente(3, "Laécio", "Laécio@gmail.com", "3234-5678 ", new DateOnly(2001, 7, 8));
            Cliente C4 = new Cliente(4, "Camila", "cami@gmail.com", "4234-5678 ", new DateOnly(1999, 7, 30));
            Cliente C5 = new Cliente(5, "Roberto", "roberto@gmail.com", "5234-5678 ", new DateOnly(1999, 5, 26));

            List<Cliente> Cliente = new List<Cliente>();
            Cliente.Add(C1);
            Cliente.Add(C2);
            Cliente.Add(C3);
            Cliente.Add(C4);
            Cliente.Add(C5);

            return View(Cliente);
        }
    }
}
