namespace Estacionamiento_C.Models
{
    public class Cliente : Persona
    {
        public int Cuil { get; set; }

        public Direccion Direccion { get; set; }// = new Direccion();
    }
}
