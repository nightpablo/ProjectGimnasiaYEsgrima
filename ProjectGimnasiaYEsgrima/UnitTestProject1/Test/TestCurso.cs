using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectGimnasiaYEsgrima.Controlador;
using ProjectGimnasiaYEsgrima.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1.Test
{
    [TestClass]
    public class TestCurso
    {
        [TestMethod]
        //Generar excepciones para probar
        //[ExpectedException(typeof(ExceptionDeporteCampoNombre))]
        //Se debe saber que las excepciones hay que generarlas desde la clase ControladorDeporte
        public void TestCursoControladorBD()
        {
            ControladorCurso controladorCurso = new ControladorCurso();

            //Aceptado
            Assert.IsTrue(controladorCurso.CrearCurso("CursoPrueba1", DateTime.Today, DateTime.Today, 2) > 0);
            Assert.IsTrue(controladorCurso.CrearCurso("Curso1234", DateTime.Today, DateTime.Today, 2) > 0);
            Curso curso_buscado = controladorCurso.BuscarCursoPorClavesUnicas("CursoPrueba1");
            Assert.IsNotNull(curso_buscado);
            Assert.IsTrue(controladorCurso.ListarTodosCursos().Count > 0);
            Assert.IsTrue(controladorCurso.ListarTodosCursosFiltro("Cur", 2).Count > 0);
            Assert.IsTrue(controladorCurso.ModificarCurso(curso_buscado.IdCurso, "CursoPrueba1", DateTime.Today, DateTime.Today, 2) > 0);
            Assert.IsTrue(controladorCurso.ListarTodosCursosFiltro("CursoPrueba1", 2).Count > 0);
            //Error
            Assert.AreEqual(controladorCurso.CrearCurso("CursoPrueba1", DateTime.Today, DateTime.Today, 2), -2);
            Assert.AreEqual(controladorCurso.ModificarCurso(curso_buscado.IdCurso, "Curso1234", DateTime.Today, DateTime.Today, 2), -2); //Debe existir Futbol en la base de datos

            //Eliminación
            Assert.IsTrue(controladorCurso.EliminarCurso(curso_buscado) > 0);
            curso_buscado = controladorCurso.BuscarCursoPorClavesUnicas("Curso1234");
            Assert.IsTrue(controladorCurso.EliminarCurso(curso_buscado) > 0);


        }
    }
}
