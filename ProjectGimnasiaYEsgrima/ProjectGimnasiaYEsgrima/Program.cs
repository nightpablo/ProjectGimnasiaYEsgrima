using ProjectGimnasiaYEsgrima.Interfaz;
using ProjectGimnasiaYEsgrima.Modelo;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Data.SqlClient;
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
            Application.Run(new InterfazPrincipal());

            //string connectionString = "data source=.;initial catalog=dbGimnasiaYEsgrima;integrated security=True";
            //try
            //{
            //    using (SqlConnection conn = new SqlConnection(connectionString))
            //    {
            //        conn.Open();
                    
            //        conn.Close();
            //    }
            //}
            //catch (Exception)
            //{
            //    MyMessageBox.Show(null,"Acceso fallida. Base de datos desconocida","¡Database Error!");
            //}
        }
        
    }
}
