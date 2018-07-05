using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGimnasiaYEsgrima
{
    public class ControladorDeporte
    {
        public int CrearDeporte(string nombre, string descripcion) //Falta empezar a generar las condiciones if's para que no fallen
        {

            Deporte un_deporte = new Deporte
            {
                Nombre = nombre,
                Descripcion = descripcion
            };



            BDDeporte una_bddeporte = new BDDeporte();
            return una_bddeporte.Crear(un_deporte);
        }
    }
}
