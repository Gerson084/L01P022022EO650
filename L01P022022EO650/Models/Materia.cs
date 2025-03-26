using System.ComponentModel.DataAnnotations;

namespace L01P022022EO650.Models
{
    public class Materia
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "Ingrese el nombre de la Materia!")]
        [StringLength(100)]
        public string materia { get; set; }

        [Required(ErrorMessage = "No olvidar la Unidad Valorativa!")]
        public int unidades_valorativas { get; set; }

        [Required(ErrorMessage = "Ingresar estado! (A = Activa, N = No disponible")]
        [StringLength(1)]
        public char estado { get; set; }
    }

}
