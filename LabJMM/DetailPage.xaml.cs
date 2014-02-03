using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using LabJMM.Code;

namespace LabJMM
{
    public partial class DetailPage : PhoneApplicationPage
    {
        public DetailPage()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            Name.Text = Global.gMesto.Name;
            Opis.Text = Global.gMesto.Opis;
            Posetiteli.Text = Global.gMesto.Posetiteli.ToString();
        }

        private void btnMapa_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate((new Uri("/Mapa.xaml", UriKind.Relative)));
        }
    }
}