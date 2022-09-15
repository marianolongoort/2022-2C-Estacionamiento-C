using Estacionamiento_C.Models;

namespace Estacionamiento_C.Data
{
    public class PersonasRepositoryEnMemoria
    {
        private List<Persona> _personas;

        public PersonasRepositoryEnMemoria()
        {
            _personas = new List<Persona>();
            Persona persona = new Persona() { Nombre = "Pedro", Apellido = "Picapiedra", Email = "pedro@ort.edu.ar" };
            Persona persona2 = new Persona() { Nombre = "Pablo", Apellido = "Marmol", Email = "pablo@ort.edu.ar" };

            _personas.Add(persona);
            _personas.Add(persona2);
        }

        public List<Persona> Personas {
            get { return _personas; }
            set { _personas = value; } 
        }


    }
}
