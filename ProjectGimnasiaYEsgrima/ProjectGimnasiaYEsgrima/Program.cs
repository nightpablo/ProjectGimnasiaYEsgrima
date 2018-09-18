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

            Application.Run(new InterfazPrincipal());
           // Application.Run(new InterfazListaDeportes());// INcremento 1
            //Application.Run(new InterfazListaCurso());
            //Application.Run(new InterfazAltaCurso());
            //Application.Run(new InterfazAltaEmpleado());
            //Application.Run(new InterfazListaEmpleado());
            //ejecute();
        }

        static void ejecute()
        {
            Deporte deporte = new Deporte()
            {
                Nombre = "Futbol1",
                Descripcion = "Cancha con una pelota"
            };
            Empleado prof = new Profesor()
            {
                FechaInicio = DateTime.Today,
                DescripcionTarea = "Profesorado de 2da categoría"
            };
            Empleado secr = new Secretaria()
            {
                FechaInicio = DateTime.Today,
                DescripcionTarea = "Licenciada en informática"
            };
            Persona per = new Persona()
            {
                Nombre="Daiana",Apellido ="Girgi",DNI=3030303,FechaNacimiento=DateTime.Today
            };

            using (var context = new DiagramasDeTablasContainer1())
            {
                context.Entry(deporte).State = System.Data.Entity.EntityState.Added;
                context.SaveChanges();
                Deporte buscado = context.Deportes.FirstOrDefault(b => b.Nombre.Equals("Futbol"));
                //((Profesor)prof).Deporte = buscado;
                prof.Persona = per;
                secr.Persona = per;
                //context.Entry(per).State = System.Data.Entity.EntityState.Added;
                //context.Entry(prof).State = System.Data.Entity.EntityState.Added;
                //context.Entry(secr).State = System.Data.Entity.EntityState.Added;
                context.Empleados.Add(prof);
                try
                {
                    context.SaveChanges();
                }
                catch (DbEntityValidationException dbEx)
                {
                    foreach (var validationErrors in dbEx.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            Trace.TraceInformation("Property: {0} Error: {1}",
                                validationError.PropertyName,
                                validationError.ErrorMessage);
                        }
                    }
                }
                
            }
        }
    }
}
