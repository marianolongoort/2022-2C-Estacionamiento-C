using Estacionamiento_C.Data;
using Estacionamiento_C.Models;
using Microsoft.AspNetCore.Mvc;

namespace Estacionamiento_C.Controllers
{
    public class PersonasOldController : Controller
    {
        private readonly EstacionamientoContext _contexto;

        public PersonasOldController(EstacionamientoContext contexto)
        {
            this._contexto = contexto;
        }

        //listar personas
        public IActionResult Index()
        {   
            return View(_contexto.Personas);
        }

        //Brindar el formulario para crear una persona.
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        //Recibir y Procesar el formulario
        [HttpPost]
        public IActionResult Create(string nombre,string apellido,string email)
        {
            Persona persona = new Persona();
            persona.Nombre = nombre;
            persona.Apellido = apellido;
            persona.Email = email;  

            _contexto.Personas.Add(persona);
            _contexto.SaveChanges();


            return RedirectToAction("Index");
        }
    }
}
