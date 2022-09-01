using Estacionamiento_C.Enums;

namespace Estacionamiento_C.Models
{
    public class Telefono
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public int CodArea { get; set; }
        public TipoTelefono Tipo { get; set; }

        public int PersonaId { get; set; }

        public Persona Persona { get; set; }

    }
}