using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Phone.Tasks;
using System.Device.Location;
using System.Device;
using Microsoft.Phone.Maps.Controls;
using LabJMM.Code;

namespace LabJMM
{
    public partial class Mapa : PhoneApplicationPage
    {
        public Mapa()
        {

           

            InitializeComponent();

            
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            myMap.Center = new GeoCoordinate(Global.gMesto.KorX, Global.gMesto.KorY);
            myMap.ZoomLevel = 17;
            myMap.CartographicMode = MapCartographicMode.Aerial;
            
        }
    }
}