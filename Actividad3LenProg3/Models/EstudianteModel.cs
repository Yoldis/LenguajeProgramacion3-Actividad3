using System.ComponentModel.DataAnnotations;

namespace Actividad3LenProg3.Models
{
    public class EstudianteModel
    {
        [Required(ErrorMessage ="El nombre es requerido")]
        [StringLength(100, ErrorMessage = "El nombre no puede exceder los 100 caracteres")]
        [Display(Name = "Nombre Completo")]
        public string NombreCompleto { get; set; }
        [Required(ErrorMessage = "La matrícula es requerida")]
        [StringLength(15, MinimumLength = 6, ErrorMessage = "La matrícula debe tener minimo 6 caracteres")]
        public string Matricula { get; set; }
        [Required(ErrorMessage = "La carrera es requerida")]
        public string Carrera { get; set; }
        [Required(ErrorMessage = "El correo electrónico es requerido")]
        [EmailAddress(ErrorMessage = "El correo electrónico no es válido")]
        [Display(Name = "Correo Electrónico")]
        public string CorreoElectronico { get; set; }
        [Phone(ErrorMessage = "El número de teléfono no es válido")]
        [MinLength(10, ErrorMessage = "El número de teléfono debe tener al menos 10 dígitos")]
        public string Telefono { get; set; }
        [Required(ErrorMessage = "La fecha de nacimiento es requerida")]
        [DataType(DataType.Date, ErrorMessage = "La fecha de nacimiento no es válida")]
        [Display(Name = "Fecha Nacimiento")]
        public DateTime FechaNacimiento { get; set; }
        [Required(ErrorMessage = "El género es requerido")]
        public string Genero { get; set; }
        [Required(ErrorMessage = "El turno es requerido")]
        [Display(Name = "Turno de Estudio")]
        public string Turno { get; set; }
        [Required(ErrorMessage = "El tipo de ingreso es requerido")]
        [Display(Name = "Tipo de Ingreso")]
        public string TipoIngreso { get; set; }
        [Required(ErrorMessage = "El estabecado es requerido")]
        [Display(Name = "¿Está Becado?")]
        public bool EstaBecado { get; set; }
        [Range(0, 100, ErrorMessage = "El porcentaje de beca debe estar entre 0 y 100")]
        [Display(Name = "Porcentaje de Beca")]
        public int PorcentajeBeca { get; set; }
        [Required(ErrorMessage = "Los terminos y condicioens son requeridos")]
        [Display(Name = "Acepto los Términos y Condiciones")]
        public bool TerminoCondicione { get; set; }
    }
}
