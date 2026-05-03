using System.ComponentModel.DataAnnotations;

namespace Act8.Models
{
    public class Estudiante
    {
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; } = string.Empty;

        [Required(ErrorMessage = "El correo es obligatorio")]
        [EmailAddress(ErrorMessage = "Correo no válido")]
        public string Correo { get; set; } = string.Empty;

        [System.ComponentModel.DataAnnotations.Range(0, 10,
            ErrorMessage = "La calificación debe estar entre 0 y 10")]
        public double Calificacion { get; set; }
    }
}
