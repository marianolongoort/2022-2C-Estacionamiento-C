using Estacionamiento_C.Data;
using Estacionamiento_C.Models;
using Microsoft.AspNetCore.Mvc;

namespace Estacionamiento_C.Controllers
{
    public class PersonasController : Controller
    {
        private readonly EstacionamientoContext _contexto;

        public PersonasController(EstacionamientoContext contexto)
        {
            this._contexto = contexto;
        }

        //listar personas
        public IActionResult Index()
        {
            Persona persona = new Persona() { Nombre = "Pedro",Apellido="Picapiedra",Email="pedro@ort.edu.ar" };
            Persona persona2 = new Persona() { Nombre = "Pablo",Apellido="Marmol" ,Email="pablo@ort.edu.ar"};

            _contexto.Personas.Add(persona);
            _contexto.Personas.Add(persona2);
            _contexto.SaveChanges();

            var personas = _contexto.Personas.ToList();

            return View(personas);
        }
    }
}
