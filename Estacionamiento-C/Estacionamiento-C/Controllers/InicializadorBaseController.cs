using Estacionamiento_C.Data;
using Estacionamiento_C.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Estacionamiento_C.Controllers
{
    public class InicializadorBaseController : Controller
    {
        private readonly EstacionamientoContext _context;

        public InicializadorBaseController(EstacionamientoContext context)
        {
            this._context = context;
        }

        public IActionResult Inicializar()
        {
            InicializarPersonas();
            InicializarClientes();

            return RedirectToAction("Index","Personas");
        }

        private void InicializarPersonas()
        {
            #region Seed primer Persona
            if (!_context.Personas.Any())
            {
                Persona persona = new Persona()
                {
                    Nombre = "Pedro",
                    Apellido = "Picapiedra",
                    Dni = 22333444,
                    Email = "pedro@ort.edu.ar"
                };
                Persona persona2 = new Persona()
                {
                    Nombre = "Pablo",
                    Apellido = "Marmol",
                    Dni = 33444555,
                    Email = "pablo@ort.edu.ar"
                };
                _context.Personas.Add(persona);
                _context.Personas.Add(persona2);
                _context.SaveChanges();
            }
            #endregion
        }

        private void InicializarClientes()
        {
            #region Seed Clietnes
            if (!_context.Clientes.Any())
            {
                Cliente persona = new Cliente()
                {
                    Nombre = "Vilma",
                    Apellido = "Picapiedra",
                    Dni = 22333444,
                    Email = "vilma@ort.edu.ar",
                    Cuil = 20223334440
                };                
                _context.Clientes.Add(persona);                
                _context.SaveChanges();
            }
            #endregion
        }
    }
}
