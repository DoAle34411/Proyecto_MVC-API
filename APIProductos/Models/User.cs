using System.ComponentModel.DataAnnotations;

namespace APIProductos.Models
{
    public class User
    {
        [Key]
        public int IdUsuario { get; set; }
        [Required]
        public string Clave { get; set; }
    }
}
