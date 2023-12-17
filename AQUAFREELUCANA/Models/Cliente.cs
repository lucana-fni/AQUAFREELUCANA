using System.ComponentModel.DataAnnotations;

namespace AQUAFREELUCANA.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        [Required, MinLength(5), MaxLength(60)]
        public string? Nombre { get; set; }
        [Required, MinLength(4), MaxLength(20)]
        public int CI { get; set; }
    }
}
