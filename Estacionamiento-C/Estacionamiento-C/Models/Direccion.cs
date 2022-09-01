using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Estacionamiento_C.Models
{
    public class Direccion
    {
        [ForeignKey("Cliente")]
        public int Id { get; set; }
        public string Calle { get; set; }
        public int Numero { get; set; }

                

        //prop nav
        public Cliente Cliente { get; set; }

    }
}