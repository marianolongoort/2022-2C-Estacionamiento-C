namespace Estacionamiento_C.Models
{
    public class Vehiculo
    {
        public int Id { get; set; }

        public string Patente { get; set; }

        public List<ClienteVehiculo> ClientesVehiculos { get; set; }
    }
}
