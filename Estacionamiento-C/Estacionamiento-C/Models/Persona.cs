namespace Estacionamiento_C.Models
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public int Dni { get; set; }

        public string Email { get; set; }

        List<Telefono> Telefonos { get; set; }

    }
}
