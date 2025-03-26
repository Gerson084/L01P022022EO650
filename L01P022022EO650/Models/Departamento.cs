using System.ComponentModel.DataAnnotations;

namespace L01P022022EO650.Models
{
    public class Departamento
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "Debe ingresar el nombre del Departamento!")]
        [StringLength(50)]
        public string departamento { get; set; }
    }
}
