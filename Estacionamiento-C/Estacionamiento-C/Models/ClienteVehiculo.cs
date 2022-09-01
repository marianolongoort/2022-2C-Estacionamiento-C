namespace Estacionamiento_C.Models
{
    public class ClienteVehiculo
    {
        public int ClienteId { get; set; }
        public int VehiculoId { get; set; }

        public Cliente Cliente { get; set; }
        public Vehiculo Vehiculo { get; set; }

    }
}