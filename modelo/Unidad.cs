using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo
{
    public class Unidad
    {

        private double longitud;
        private double latitud;
        private String nombreClave;
        

        public Unidad(double longitud, double latitud, String nombreClave)
        {
            this.Longitud = longitud;
            this.Latitud = latitud;
            this.NombreClave = nombreClave;
            

        }

        public double Longitud { get => longitud; set => longitud = value; }
        public double Latitud { get => latitud; set => latitud = value; }
        public string NombreClave { get => nombreClave; set => nombreClave = value; }
    }
}
