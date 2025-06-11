using Actividad3LenProg3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Actividad3LenProg3.Controllers
{
    public class EstudiantesController : Controller
    {
        public List<EstudianteModel> estudiantes = new List<EstudianteModel>()
        {
            new EstudianteModel {
                NombreCompleto = "Juan Perez", Matricula = "2023001",
                Carrera = "Ingeniería de Sistemas",
                CorreoElectronico = "juan@example.com",
                Telefono = "1234567890", FechaNacimiento = new DateTime(2000, 1, 1),
                Genero= "Masculino", Turno = "Matutino",
                EstaBecado = true, PorcentajeBeca = 50,
                TipoIngreso = "Regular", TerminoCondicione = true
               }
        };
        
        public IActionResult Index()
        {
            return View("Formulario");
        }

        [HttpPost]
        public IActionResult Registrar(EstudianteModel estudiante)
        {
            bool existEstudiante = estudiantes.Any(e => e.Matricula == estudiante.Matricula);
            if (!ModelState.IsValid || existEstudiante)
            {
                return View("formulario", estudiante);
            }
            estudiantes.Add(estudiante);
            return View("Lista", estudiantes);
        }

        public IActionResult Lista()
        {
            return View(estudiantes);
        }

        public IActionResult Editar()
        {
            return View();
        }
        public IActionResult BuscarMatricula()
        {
            return View();
        }
        public IActionResult Eliminar()
        {
            return View();
        }
    }
}
