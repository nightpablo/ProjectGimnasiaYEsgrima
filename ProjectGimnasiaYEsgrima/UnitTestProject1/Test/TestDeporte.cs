using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectGimnasiaYEsgrima.Modelo;
using ProjectGimnasiaYEsgrima.Controlador;
using ProjectGimnasiaYEsgrima;
using System;
using System.Globalization;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        //Generar excepciones para probar
        //[ExpectedException(typeof(ExceptionDeporteCampoNombre))]
        //Se debe saber que las excepciones hay que generarlas desde la clase ControladorDeporte
        public void TestDeporteControladorBD()
        {

            ControladorDeporte controladorDeporte = new ControladorDeporte();

            //Aceptado
            Assert.IsTrue(controladorDeporte.CrearDeporte("FutbolPrueba", "pepeeejd") > 0);
            Assert.IsTrue(controladorDeporte.CrearDeporte("NatacionPrueba", "") > 0);
            Deporte deporte_buscado = controladorDeporte.BuscarDeportePorClavesUnicas("FutbolPrueba");
            Assert.IsNotNull(deporte_buscado);
            Assert.IsTrue(controladorDeporte.ListarTodosDeportes().Count > 0);
            Assert.IsTrue(controladorDeporte.ListarTodosDeportesPorFiltros("ut", "").Count > 0);
            Assert.IsTrue(controladorDeporte.ModificarDeporte(deporte_buscado.IdDeporte, "FutbolPrueba", "Futbol en Testing") > 0);
            Assert.IsTrue(controladorDeporte.ListarTodosDeportesPorFiltros("", "Futbol en Test").Count > 0);
            //Error
            Assert.AreEqual(controladorDeporte.CrearDeporte("FutbolPrueba", ""), -2);
            Assert.IsFalse(controladorDeporte.ListarTodosDeportesPorFiltros("z", "").Count > 0);
            Assert.IsFalse(controladorDeporte.ListarTodosDeportesPorFiltros("", "z").Count > 0);
            //Eliminación
            Assert.IsTrue(controladorDeporte.EliminarDeporte(deporte_buscado) > 0);
            deporte_buscado = controladorDeporte.BuscarDeportePorClavesUnicas("NatacionPrueba");
            Assert.IsTrue(controladorDeporte.EliminarDeporte(deporte_buscado) > 0); //Como que se eliminaron todo, todavia debe existir en la bd pero en estado BAJA
            //Recuperación
            Assert.IsTrue(controladorDeporte.CrearDeporte("FutbolPrueba", "Recuperando Futbol") == -1);
            Assert.IsTrue(controladorDeporte.CrearDeporte("NatacionPrueba", "Recuperando Natacion") == -1);

        }

        [TestMethod]
        public void TestCursoControladorBD()
        {
            // Una vez ejecutada el testing de Deporte debieron haber sido creado 2 deportes nuevos
            ControladorDeporte controladorDeporte = new ControladorDeporte();
            ControladorCurso controladorCurso = new ControladorCurso();

            DateTime Inicio = DateTime.ParseExact("01/08/2018", "dd/MM/yyyy", CultureInfo.InvariantCulture);
            DateTime Fin = DateTime.ParseExact("30/11/2018", "dd/MM/yyyy", CultureInfo.InvariantCulture);
            //Aceptado
            Assert.IsTrue(controladorCurso.CrearCurso("FutbolPrueba 2do cuastrimestre 2018", 600, Inicio, Fin, controladorDeporte.BuscarDeportePorClavesUnicas("FutbolPrueba")) > 0);
            Assert.IsTrue(controladorCurso.CrearCurso("NatacionPrueba 2do cuastimestre 2018", 500, Inicio, Fin, controladorDeporte.BuscarDeportePorClavesUnicas("NatacionPrueba")) > 0);
            Curso curso_buscado = controladorCurso.BuscarCursoPorClavesUnicas("FutbolPrueba 2do cuastrimestre 2018");
            Assert.IsNotNull(curso_buscado);
            Assert.IsTrue(controladorCurso.ListarTodosCursos().Count > 0);
            Assert.IsTrue(controladorCurso.ListarTodosCursosFiltro("cuastr", controladorDeporte.BuscarDeportePorClavesUnicas("FutbolPrueba")).Count > 0);
            Assert.IsTrue(controladorCurso.ModificarCurso(curso_buscado.IdCurso, "FutbolPrueba 2do cuastrimestre 2018", 1200, Inicio, Fin, controladorDeporte.BuscarDeportePorClavesUnicas("FutbolPrueba"), EnumEstadoCurso.Activo) > 0);
            //Error
            Assert.AreEqual(controladorCurso.CrearCurso("FutbolPrueba 2do cuastrimestre 2018", 600, Inicio, Fin, controladorDeporte.BuscarDeportePorClavesUnicas("FutbolPrueba")), -2);
            Assert.IsFalse(controladorCurso.ListarTodosCursosFiltro("z", controladorDeporte.BuscarDeportePorClavesUnicas("FutbolPrueba")).Count > 0);
            Assert.IsFalse(controladorCurso.ListarTodosCursosFiltro("FutbolPrueba", controladorDeporte.BuscarDeportePorClavesUnicas("NatacionPrueba")).Count > 0);
            //Eliminación
            Assert.IsTrue(controladorCurso.EliminarCurso(curso_buscado) > 0);
            curso_buscado = controladorCurso.BuscarCursoPorClavesUnicas("NatacionPrueba 2do cuastimestre 2018");
            Assert.IsTrue(controladorCurso.EliminarCurso(curso_buscado) > 0); //Como que se eliminaron todo, todavia debe existir en la bd pero en estado BAJA
            //Recuperación
            Assert.IsTrue(controladorCurso.CrearCurso("FutbolPrueba 2do cuastrimestre 2018", 9950, Inicio, Fin, controladorDeporte.BuscarDeportePorClavesUnicas("FutbolPrueba")) == -1);
            Assert.IsTrue(controladorCurso.CrearCurso("NatacionPrueba 2do cuastimestre 2018", 6540, Inicio, Fin, controladorDeporte.BuscarDeportePorClavesUnicas("NatacionPrueba")) == -1);
        }

        [TestMethod]
        public void TestEmpleadoControladorBD()
        {
            // Una vez ejecutada los testings anteriores debieron haber sido creado los nuevos datos antes de continuar con esta prueba.
            ControladorCurso controladorCurso = new ControladorCurso();
            ControladorEmpleado controladorEmpleado = new ControladorEmpleado();

            DateTime FechaNacimiento = DateTime.ParseExact("06/11/1991", "dd/MM/yyyy", CultureInfo.InvariantCulture);
            DateTime FechaInicio = DateTime.ParseExact("01/04/2017", "dd/MM/yyyy", CultureInfo.InvariantCulture);
            //Aceptado
            Assert.IsTrue(controladorEmpleado.CrearEmpleado("Pablo", "Barragan", FechaNacimiento, 36000000, "Profesor de futbol", FechaInicio, EnumTipoEmpleado.Profesor) > 0);
            Assert.IsTrue(controladorEmpleado.CrearEmpleado("Daiana", "Giorgi", FechaNacimiento, 36001111, "Secretaria del departamento de registro", FechaInicio, EnumTipoEmpleado.Secretaria) > 0);
            Assert.IsTrue(controladorEmpleado.CrearEmpleado("Leandro", "Long", FechaNacimiento, 36002222, "Directivo seleccionado por el 80 por ciento de los socios", FechaInicio, EnumTipoEmpleado.Directivo) > 0);
            ModelEmpleadoPersona empleado_buscado = controladorEmpleado.BuscarEmpleadoPorClavesUnicasPorVista(36000000);
            Assert.IsNotNull(empleado_buscado);
            Assert.IsTrue(controladorEmpleado.ExtraerEmpleadosAVista().Count > 0);
            Assert.IsTrue(controladorEmpleado.ExtraerEmpleadosAVista("blo", "", "", "").Count > 0);
            Assert.IsTrue(controladorEmpleado.ExtraerEmpleadosAVista("", "or", "", "").Count > 0);
            Assert.IsTrue(controladorEmpleado.ExtraerEmpleadosAVista("", "", "36", "").Count > 0);
            Assert.IsTrue(controladorEmpleado.ExtraerEmpleadosAVista("", "", "", "Secretaria").Count > 0);
            Assert.IsTrue(controladorEmpleado.ModificarEmpleado(empleado_buscado.MiPersona.IdPersona, empleado_buscado.MiEmpleado.IdEmpleado, "Pablito clavo un clavito", "Clavito clavo un pablito", FechaNacimiento, 36000000, "Se equivoco de profesorado", FechaInicio, EnumTipoEmpleado.Profesor, EnumEstadoEmpleado.Activo) > 0);
            //Error
            Assert.AreEqual(controladorEmpleado.CrearEmpleado("OtraPersona", "OtraPersona", FechaNacimiento, 36000000, "Otro Descrip", FechaInicio, EnumTipoEmpleado.Mantenimiento), -2);
            Assert.IsFalse(controladorEmpleado.ExtraerEmpleadosAVista("z", "", "", "").Count > 0);
            Assert.IsFalse(controladorEmpleado.ExtraerEmpleadosAVista("", "z", "", "").Count > 0);
            Assert.IsFalse(controladorEmpleado.ExtraerEmpleadosAVista("", "", "z", "").Count > 0);
            Assert.IsFalse(controladorEmpleado.ExtraerEmpleadosAVista("", "", "", "Mantenimiento").Count > 0);
            //Eliminación
            Assert.IsTrue(controladorEmpleado.EliminarEmpleado(empleado_buscado.MiEmpleado) > 0);
            empleado_buscado = controladorEmpleado.BuscarEmpleadoPorClavesUnicasPorVista(36001111);
            Assert.IsTrue(controladorEmpleado.EliminarEmpleado(empleado_buscado.MiEmpleado) > 0);
            empleado_buscado = controladorEmpleado.BuscarEmpleadoPorClavesUnicasPorVista(36002222);
            Assert.IsTrue(controladorEmpleado.EliminarEmpleado(empleado_buscado.MiEmpleado) > 0);
            //Recuperación
            Assert.IsTrue(controladorEmpleado.CrearEmpleado("Pablo", "Barragan", FechaNacimiento, 36000000, "Recuperando Profesor de futbol", FechaInicio, EnumTipoEmpleado.Profesor) == -1);
            Assert.IsTrue(controladorEmpleado.CrearEmpleado("Daiana", "Giorgi", FechaNacimiento, 36001111, "Recuperando Secretaria del departamento de registro", FechaInicio, EnumTipoEmpleado.Secretaria) == -1);
            Assert.IsTrue(controladorEmpleado.CrearEmpleado("Leandro", "Long", FechaNacimiento, 36002222, "Recuperando Directivo seleccionado por el 80 por ciento de los socios", FechaInicio, EnumTipoEmpleado.Directivo) == -1);
            //Relacion Empleado Curso
            empleado_buscado = controladorEmpleado.BuscarEmpleadoPorClavesUnicasPorVista(36000000);
            Assert.IsTrue(controladorCurso.AsignarEmpleadoAlCurso(empleado_buscado.MiEmpleado, controladorCurso.BuscarCursoPorClavesUnicas("FutbolPrueba 2do cuastrimestre 2018")) > 0);
            //Error intento de agregar de nuevo
            Assert.IsTrue(controladorCurso.AsignarEmpleadoAlCurso(empleado_buscado.MiEmpleado, controladorCurso.BuscarCursoPorClavesUnicas("FutbolPrueba 2do cuastrimestre 2018")) == -2);
            //Eliminar relacion Empleado Curso
            empleado_buscado = controladorEmpleado.BuscarEmpleadoPorClavesUnicasPorVista(36000000);
            Assert.IsTrue(controladorCurso.EliminarEmpleadoDelCurso(empleado_buscado.MiEmpleado, controladorCurso.BuscarCursoPorClavesUnicas("FutbolPrueba 2do cuastrimestre 2018")) > 0);
            //Error intento de eliminar de nuevo
            Assert.IsTrue(controladorCurso.EliminarEmpleadoDelCurso(empleado_buscado.MiEmpleado, controladorCurso.BuscarCursoPorClavesUnicas("FutbolPrueba 2do cuastrimestre 2018")) == -2);
        }

        [TestMethod]
        public void TestLoginEmpleadoControladorBD()
        {
            // Una vez ejecutada los testings anteriores debieron haber sido creado los nuevos datos antes de continuar con esta prueba.
            ControladorEmpleado controladorEmpleado = new ControladorEmpleado();
            Empleado secretaria_buscado = controladorEmpleado.BuscarEmpleadoPorClavesUnicasPorVista(36001111).MiEmpleado;
            Empleado directivo_buscado = controladorEmpleado.BuscarEmpleadoPorClavesUnicasPorVista(36002222).MiEmpleado;
            using (var context = new DiagramasDeTablasContainer1()) // Se guarda nuevos login en la base de datos de manera manual sin uso de controlador
            {

                context.Entry(new Login() { Empleado = secretaria_buscado, usuario = "dgiorgi", contraseña = "dgiorgi" }).State = System.Data.Entity.EntityState.Added;
                context.Entry(new Login() { Empleado = directivo_buscado, usuario = "llong", contraseña = "llong" }).State = System.Data.Entity.EntityState.Added;
                context.SaveChanges();
            }
            //Aceptación
            Assert.IsNotNull(controladorEmpleado.VerificarLoginEmpleado("dgiorgi", "dgiorgi"));
            Assert.IsNotNull(controladorEmpleado.VerificarLoginEmpleado("llong", "llong"));
            //Rechazo
            Assert.IsNull(controladorEmpleado.VerificarLoginEmpleado("dgiorgi", "llong"));
            Assert.IsNull(controladorEmpleado.VerificarLoginEmpleado("llong", "dgiorgi"));
            Assert.IsNull(controladorEmpleado.VerificarLoginEmpleado("xaz", "xaz"));
            Assert.IsNull(controladorEmpleado.VerificarLoginEmpleado("dgiorgi", ""));
            Assert.IsNull(controladorEmpleado.VerificarLoginEmpleado("", "dgiorgi"));
        }

        public void TestSocioControladorBD()
        {
            // Una vez ejecutada los testings anteriores debieron haber sido creado los nuevos datos antes de continuar con esta prueba.

        }


    }
}
