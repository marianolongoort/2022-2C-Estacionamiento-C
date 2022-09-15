namespace Estacionamiento_C.Models
{
    public class Cliente : Persona
    {

        public long Cuil { get; set; }

        //prop nav
        public Direccion Direccion { get; set; }// = new Direccion();

        //prop nav
        //public List<ClienteVehiculo> ClientesVehiculos{ get; set; }
    }
}
