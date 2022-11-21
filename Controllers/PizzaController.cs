using Microsoft.AspNetCore.Mvc;

namespace la_mia_pizzeria_static.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            //ListaPizze listaPizze = new ListaPizze("Mario", "Rossi", 25);

        return View();
        }
    }
}
