using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo
{
    public class SystemB

    {
       public ArrayList depoloyedUnits;

        public SystemB()
        {
            depoloyedUnits = new ArrayList();
            readFiles();
        }

        public ArrayList DepoloyedUnits { get => depoloyedUnits; set => depoloyedUnits = value; }

        public void readFiles()
        {

            //"...\\..\\archivos\\ZONAS_WIFI_GRATIS_PARA_LA_GENTE.csv"
            StreamReader st = new StreamReader("...\\..\\archivos\\data.csv");

            string line = st.ReadLine();
            line = st.ReadLine();
            

            while (line != null)
            {

                string[] info = line.Split(',');
                string name = info[0];
                string longitud = info[1];
                string latitud = info[2];

                Console.WriteLine(double.Parse(longitud, System.Globalization.CultureInfo.InvariantCulture) + "--" + Convert.ToDouble(latitud));
                
                depoloyedUnits.Add(new Unidad(double.Parse(longitud, System.Globalization.CultureInfo.InvariantCulture), double.Parse(latitud, System.Globalization.CultureInfo.InvariantCulture), name));
                
                line = st.ReadLine();
            }
            st.Close();
        }





       
    }


 }

