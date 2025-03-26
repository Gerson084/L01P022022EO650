using System.ComponentModel.DataAnnotations;

namespace L01P022022EO650.Models
{
    public class alumnos
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "Debe ingresar el Codigo del Alumno!")]
        [StringLength(10)]
        public string codigo { get; set; }

        [Required(ErrorMessage = "Debe ingresar el Nombre")]
        [StringLength(50)]
        public string nombre { get; set; }

        [Required(ErrorMessage = "Debe ingresar el Apellido!")]
        [StringLength(50)]
        public string apellidos { get; set; }

        [Required(ErrorMessage = "Debe ingresar el DUI!")]
        public int dui { get; set; }

        public int estado { get; set; }
    }
}
