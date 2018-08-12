using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectGimnasiaYEsgrima.Modelo;
using ProjectGimnasiaYEsgrima.Controlador;
using ProjectGimnasiaYEsgrima;

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
            Assert.IsTrue(controladorDeporte.CrearDeporte("FutbolPrueba1", "")>0);
            Deporte deporte_buscado = controladorDeporte.BuscarDeportePorClavesUnicas("FutbolPrueba1");
            Assert.IsNotNull(deporte_buscado);
            Assert.IsTrue(controladorDeporte.ListarTodosDeportes().Count > 0);
            Assert.IsTrue(controladorDeporte.ListarTodosDeportesPorFiltros("futbolprueba1","").Count > 0);
            Assert.IsTrue(controladorDeporte.ModificarDeporte(deporte_buscado.Iddeporte, "FutbolPrueba1", "Futbol en Testing")>0);
            Assert.IsTrue(controladorDeporte.ListarTodosDeportesPorFiltros("", "Futbol en Test").Count > 0);
            //Error
            Assert.AreEqual(controladorDeporte.CrearDeporte("FutbolPrueba1", ""),-2);
            Assert.AreEqual(controladorDeporte.ModificarDeporte(deporte_buscado.Iddeporte,"Futbol", ""), -2); //Debe existir Futbol en la base de datos

            //Eliminación
            Assert.IsTrue(controladorDeporte.EliminarDeporte(deporte_buscado) > 0);

        }


    }
}
