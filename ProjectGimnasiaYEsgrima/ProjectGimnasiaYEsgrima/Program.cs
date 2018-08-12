using ProjectGimnasiaYEsgrima.Interfaz;
using System;
using System.Collections.Generic;
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
            //Application.Run(new InterfazDeporte());
            Application.Run(new InterfazListaDeportes());// INcremento 1
            //Application.Run(new InterfazAltaCurso());
        }
    }
}
