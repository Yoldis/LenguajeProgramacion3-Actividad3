using System.ComponentModel.DataAnnotations;

namespace Actividad3LenProg3.Models
{
    public class EstudianteModel
    {
        [Required(ErrorMessage ="El nombre es requerido")]
        [StringLength(100, ErrorMessage = "El nombre no puede exceder los 100 caracteres")]
        public string NombreCompleto { get; set; }
        [Required(ErrorMessage = "La matrícula es requerida")]
        [StringLength(15, MinimumLength =6, ErrorMessage = "La matrícula debe tener minimo 6 caracteres")]
        public string Matricula { get; set; }
        [Required(ErrorMessage = "La carrera es requerida")]
        public string Carrera { get; set; }
        [Required(ErrorMessage = "El correo electrónico es requerido")]
        [EmailAddress(ErrorMessage = "El correo electrónico no es válido")]
        public string CorreoElectronico { get; set; }
        [Phone(ErrorMessage = "El número de teléfono no es válido")]
        [MinLength(10, ErrorMessage = "El número de teléfono debe tener al menos 10 dígitos")]
        public string Telefono { get; set; }
        [Required(ErrorMessage = "La fecha de nacimiento es requerida")]
        [DataType(DataType.Date, ErrorMessage = "La fecha de nacimiento no es válida")]
        public DateTime FechaNacimiento { get; set; }
        [Required(ErrorMessage = "El género es requerido")]
        public string Genero { get; set; }
        [Required(ErrorMessage = "El turno es requerido")]
        public string Turno { get; set; }
        [Required(ErrorMessage = "El tipo de ingreso es requerido")]
        public string TipoIngreso { get; set; }
        [Range(typeof(bool), "true", "false", ErrorMessage = "Debe seleccionar si esta becado")]
        public bool EstaBecado { get; set; }
        [Range(0, 100, ErrorMessage = "El porcentaje de beca debe estar entre 0 y 100")]
        public int PorcentajeBeca { get; set; }
        [Range(typeof(bool), "true", "false", ErrorMessage = "Debe aceptar los términos y condiciones")]
        public bool TerminoCondiciones { get; set; }
    }
}
