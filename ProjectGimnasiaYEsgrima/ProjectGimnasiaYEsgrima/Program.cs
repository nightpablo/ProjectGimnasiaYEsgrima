using ProjectGimnasiaYEsgrima.Interfaz;
using ProjectGimnasiaYEsgrima.Modelo;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectGimnasiaYEsgrima
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            
            //ejecute();
            Application.Run(new InterfazPrincipal());
        }

        static void ejecute()
        {
            Controlador.ControladorDeporte CDeporte = new Controlador.ControladorDeporte();
            Controlador.ControladorCurso CCurso = new Controlador.ControladorCurso();
            Controlador.ControladorEmpleado CEmpleado = new Controlador.ControladorEmpleado();
            Controlador.ControladorSocio CSocio = new Controlador.ControladorSocio();

            CDeporte.CrearDeporte("Futbol", "Cancha de futbol que se utiliza una pelota y se juega 11 jugadores contra 11 jugadores");
            CDeporte.CrearDeporte("Basquet", "Cancha de basquet que se utiliza una pelota y se juega 5 jugadores contra 5 jugadores");
            CDeporte.CrearDeporte("Natacion", "Se compone de una pileta de 30 metros y hasta 8 competidores pueden participar");

            CCurso.CrearCurso("Futbol 2019 Cuastimestre 1", 1500, DateTime.Now, DateTime.Now, CDeporte.BuscarDeportePorClavesUnicas("Futbol"));
            CCurso.CrearCurso("Futbol 2019 Cuastimestre 2", 1700, DateTime.Now, DateTime.Now, CDeporte.BuscarDeportePorClavesUnicas("Futbol"));
            CCurso.CrearCurso("Basquet 2019 Cuastimestre 1", 1200, DateTime.Now, DateTime.Now, CDeporte.BuscarDeportePorClavesUnicas("Basquet"));

            CEmpleado.CrearEmpleado("Pablo", "Barragan", DateTime.Now, 36000000, "Profesor de Futbol", DateTime.Now, EnumTipoEmpleado.Profesor);
            CEmpleado.CrearEmpleado("Daiana", "Giorgi", DateTime.Now, 36001111, "Secretaria de departamento", DateTime.Now, EnumTipoEmpleado.Secretaria);
            CEmpleado.CrearEmpleado("Leandro", "Long", DateTime.Now, 36002222, "Directivo seleccionado por varios votos del club", DateTime.Now, EnumTipoEmpleado.Directivo);

            CCurso.AsignarEmpleadoAlCurso(CEmpleado.BuscarEmpleadoPorClavesUnicasPorVista(36000000).MiEmpleado, CCurso.BuscarCursoPorClavesUnicas("Futbol 2019 Cuastimestre 1"));

        }
    }
}
