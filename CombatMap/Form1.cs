using GMap.NET.MapProviders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using modelo;
using GMap.NET;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms;

namespace CombatMap
{
    public partial class MapUnit : Form
    {

        private GMapOverlay markers;

        public MapUnit()
        {

            InitializeComponent();
            markers = new GMapOverlay("markers");
            mostrarRegimientos();
           
            
        }

        private void MapUnit_Load(object sender, EventArgs e)
        {
            
            map.MapProvider = GMapProviders.GoogleMap;
            
            /*map.Position = new PointLatLng(4.5709, -74.2973)*/
            ;
            map.MinZoom = 1;
            map.MaxZoom = 100;
            map.Zoom = 5;
            


        }

  
        private void BotonAgregar_Click(object sender, EventArgs e)
        {

            try {
                markers.Markers.Add(new GMarkerGoogle(new PointLatLng(double.Parse(cajaLatitud.Text, System.Globalization.CultureInfo.InvariantCulture),
                double.Parse(cajaLongitud.Text, System.Globalization.CultureInfo.InvariantCulture)), GMarkerGoogleType.green_dot));
            } catch (Exception rare)
            {
                
            }
            
            map.Overlays.Clear();
            map.Overlays.Add(markers);
        }

        private void mostrarRegimientos()
        {
            SystemB nuevo = new SystemB();
            
            GMapMarker marker;
       
            //label1.Text = ((Unidad)nuevo.depoloyedUnits[0]).Latitud+"";

            foreach (Unidad unit in nuevo.depoloyedUnits)
            {
               
                markers.Markers.Add(new GMarkerGoogle(new PointLatLng(unit.Longitud, unit.Latitud), GMarkerGoogleType.blue_dot));
                

            }
            

            map.SetPositionByKeywords("Colombia, Bogotá");
           
            
            map.Overlays.Add(markers);
        }
    }
}
