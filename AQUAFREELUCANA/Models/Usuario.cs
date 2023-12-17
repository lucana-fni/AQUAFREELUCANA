using AQUAFREELUCANA.Dtos;
using System.ComponentModel.DataAnnotations;

namespace AQUAFREELUCANA.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        [Required, MinLength(5), MaxLength(50)]
        public string? Cuenta { get; set; }
        [Required, MinLength(5), MaxLength(50)]
        public string? Password { get; set; }
        [Required, MinLength(3), MaxLength(60)]
        public string? NombreCompleto { get; set; }
        [Required]
        public RolEnum? Rol { get; set; }
    }
}
