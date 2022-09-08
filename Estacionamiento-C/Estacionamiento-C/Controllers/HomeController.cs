using Estacionamiento_C.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Estacionamiento_C.Controllers
{
    public class HomeController : Controller
    {
      


        public IActionResult Index()
        {
            ViewResult vistaResultante = View();

            return vistaResultante;
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public IActionResult MostrarNumeros(string nombre = "Pedro",string apellido = "Picapiedra")
        {           
            
            ViewBag.Persona = DamePersona(nombre,apellido);

            return View(DameNumeros());
        }

        private Persona DamePersona(string nombre, string apellido)
        {
            Persona persona = new Persona()
            {
                Apellido = apellido,
                Nombre = nombre
            };




            return persona;
        }

        private List<int> DameNumeros()
        {
            List<int> numeros = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            
            return DamePares(numeros);
        }

        private List<int> DamePares(List<int> numeritos)
        {
            List<int> pares = numeritos
                .Where(num => num % 2 ==0 && num > 4)
                .OrderByDescending(numer => numer)
                .ToList();        

            

            return pares;
        }

    }
}