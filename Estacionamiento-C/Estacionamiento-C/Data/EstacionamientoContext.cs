using Estacionamiento_C.Models;
using Microsoft.EntityFrameworkCore;

namespace Estacionamiento_C.Data
{
    public class EstacionamientoContext : DbContext
    {
        public EstacionamientoContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Persona> Personas { get; set; }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Empleado> Empleado { get; set; }

        //public DbSet<ClienteVehiculo> ClientesVehiculos { get; set; }

    }
}
