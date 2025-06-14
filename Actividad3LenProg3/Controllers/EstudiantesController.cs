using Actividad3LenProg3.Models;
using Microsoft.AspNetCore.Mvc;
using System;


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
            return View("Crear");
        }

        [HttpPost]
        public IActionResult Registrar(EstudianteModel estudiante)
        {
            bool existEstudiante = estudiantes.Any(e => e.Matricula == estudiante.Matricula);
            if (!ModelState.IsValid || existEstudiante)
            {
                return View("Crear", estudiante);
            }
            estudiantes.Add(estudiante);
            return View("Lista", estudiantes);
        }

        [HttpGet]
        public IActionResult Lista()
        {
            return View(estudiantes);
        }

        [HttpGet]
        public IActionResult Editar(string matricula)
        {
            var estudianteEncontrado = estudiantes.FirstOrDefault(e => e.Matricula == matricula);
            if (estudianteEncontrado == null)
            {
                ViewBag.Mensaje = "Estudiante no encontrado.";
                //return View("Lista", estudiantes);
            }

            return View("Editar", estudianteEncontrado);
        }


        [HttpPost]
        public IActionResult Editar(EstudianteModel estudiante)
        {
            var index = estudiantes.FindIndex(e => e.Matricula == estudiante.Matricula);
            if (index != -1)
            {
                estudiantes[index] = estudiante;
                return View("Lista", estudiantes);
            }
            
            ViewBag.Mensaje = "Estudiante no encontrado.";
            return View("Lista", estudiantes); 
        }

        [HttpGet]
        public IActionResult Eliminar(string matricula)
        {
            var estudiante = estudiantes.FirstOrDefault(e => e.Matricula == matricula);
            if (estudiante == null)
            {
                return NotFound();
            }

            estudiantes.Remove(estudiante);

            return View("Lista", estudiantes);
        }
    }
}
