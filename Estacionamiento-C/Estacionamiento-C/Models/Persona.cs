using Estacionamiento_C.Helpers;
using System.ComponentModel.DataAnnotations;

namespace Estacionamiento_C.Models
{
    public class Persona
    {

        public int Id { get; set; }

        [Required(ErrorMessage = ErrorMsg.MsgRequired)]
        [MaxLength(50,ErrorMessage = ErrorMsg.MsgMaxStr)]
        [MinLength(2,ErrorMessage = ErrorMsg.MsgMinStr)]
        public string Nombre { get; set; }


        [Required(ErrorMessage = ErrorMsg.MsgRequired)]
        [StringLength(100,MinimumLength = 2,ErrorMessage = "{0} debe estar comprendido entre {2} y {1} caracteres")]
        public string Apellido { get; set; }


        [Required(ErrorMessage = ErrorMsg.MsgRequired)]
        [Range(1000000,99999999,ErrorMessage = "El {0} debe estar comprendido entre {1} y {2}")]
        public int Dni { get; set; }


        [Required(ErrorMessage = ErrorMsg.MsgRequired)]
        [EmailAddress(ErrorMessage = ErrorMsg.MsgEmail)]
        [Display(Name = "Correo electronico")]
        public string Email { get; set; }

        public List<Telefono> Telefonos { get; set; }

    }
}
