using Microsoft.VisualStudio.TestTools.UnitTesting;
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
        public void Campo1_nombre()
        {
            ControladorDeporte controladorDeporte = new ControladorDeporte();

            //Aceptado
            controladorDeporte.CrearDeporte("Futbol5", "");
            //Error
            controladorDeporte.CrearDeporte("FUTBOLFUTBOLFUTBOLFUTBOLFUTBOLF", "");
            controladorDeporte.CrearDeporte("", "");

            //Repetido y Error
            controladorDeporte.CrearDeporte("Futbol", "");

        }

        [TestMethod]
        //Generar excepciones para probar
        //[ExpectedException(typeof(ExceptionDeporteCampoDescripcion))]
        public void Campo1_descripcion()
        {
            ControladorDeporte controladorDeporte = new ControladorDeporte();

            //Aceptado
            controladorDeporte.crearDeporte("Futbol1", "Deporte que se practica entre dos equipos de once jugadores que tratan de introducir un balón en la portería del contrario impulsándolo con los pies, la cabeza o cualquier parte del cuerpo excepto las manos y los brazos; en cada equipo hay un portero, que puede tocar el balón con las manos, aunque solamente dentro del área; vence el equipo que logra más goles durante los 90 minutos que dura el encuentro.");
            controladorDeporte.crearDeporte("Futbol9", "");
            //Error
            controladorDeporte.crearDeporte("Futbol11", "Deporte que se practica entre dos equipos de once jugadores que tratan de introducir un balón en la portería del contrario impulsándolo con los pies, la cabeza o cualquier parte del cuerpo excepto las manos y los brazos; en cada equipo hay un portero, que puede tocar el balón con las manos, aunque solamente dentro del área; vence el equipo que logra más goles durante los 90 minutos que dura el encuentro.Deporte que se practica entre dos equipos de once jugadores que tratan de introducir un balón en la portería del contrario impulsándolo con los pies, la cabeza o cualquier parte del cuerpo excepto las manos y los brazos; en cada equipo hay un portero, que puede tocar el balón con las manos, aunque solamente dentro del área; vence el equipo que logra más goles durante los 90 minutos que dura el encuentro.");

        }


    }
}
