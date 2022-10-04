using Microsoft.AspNetCore.Mvc;

namespace la_mia_pizzeria_static.Controllers
{
    public class PizzaController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {

            /// FAKE DB
            Pizza pizzaMargherita = new("margherita", "pizza margherita", "/img/img-1.jpg", 33.3m);
            Pizza pizzaNapoli = new("napoli", "pizza napoli", "/img/img-2.jpeg", 13);
            Pizza pizzaBufala = new("bufala", "pizza bufala", "/img/img-3.jpeg", 15.5m);
            Pizza pizzaMarinara = new("marinara", "pizza marinara", "/img/img-1.jpg", 33.3m);
            Pizza pizzaQuattroFormaggi = new("quattro formaggi", "pizza quatro formaggi", "/img/img-2.jpeg", 13);
            Pizza pizzaBianca = new("bianca", "pizza bianca", "/img/img-3.jpeg", 15.5m);

            List<Pizza> myMenu =new List<Pizza>();
            myMenu.Add(pizzaMargherita);
            myMenu.Add(pizzaNapoli);
            myMenu.Add(pizzaBufala);
            myMenu.Add(pizzaMarinara);
            myMenu.Add(pizzaQuattroFormaggi);
            myMenu.Add(pizzaBianca);

            //myMenu.Clear();

            return View("Index", myMenu);
        }

        public IActionResult Details(int id)
        {

            /// FAKE DB
            Pizza pizzaMargherita = new("margherita", "pizza margherita", "/img/img-1.jpg", 33.3m);
            Pizza pizzaNapoli = new("napoli", "pizza napoli", "/img/img-2.jpeg", 13);
            Pizza pizzaBufala = new("bufala", "pizza bufala", "/img/img-3.jpeg", 15.5m);
            Pizza pizzaMarinara = new("marinara", "pizza marinara", "/img/img-1.jpg", 33.3m);
            Pizza pizzaQuattroFormaggi = new("quattro formaggi", "pizza quatro formaggi", "/img/img-2.jpeg", 13);
            Pizza pizzaBianca = new("bianca", "pizza bianca", "/img/img-3.jpeg", 15.5m);

            List<Pizza> myMenu = new List<Pizza>();
            myMenu.Add(pizzaMargherita);
            myMenu.Add(pizzaNapoli);
            myMenu.Add(pizzaBufala);
            myMenu.Add(pizzaMarinara);
            myMenu.Add(pizzaQuattroFormaggi);
            myMenu.Add(pizzaBianca);

            Pizza pizza = myMenu[id];

            return View("Show", myMenu[id]);
        }
    }
}
