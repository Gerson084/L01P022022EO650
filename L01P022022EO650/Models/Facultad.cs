using System.ComponentModel.DataAnnotations;

namespace L01P022022EO650.Models
{
    public class Facultad
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "Debe ingresar el nombre de la Facultad!")]
        [StringLength(100)]
        public string facultad { get; set; }
    }
}
