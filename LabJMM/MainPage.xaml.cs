using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using LabJMM.Resources;
using LabJMM.Code;
using LabJMM.ViewModelNamespace;

namespace LabJMM
{
    public partial class MainPage : PhoneApplicationPage
    {
     

        // Constructor
        public MainPage()
        {
            InitializeComponent();

            Global.vm.GetNastani();
            MestoViewOnPage.DataContext = Global.vm.Mesta;
            PrikazViewOnPage.DataContext = Global.vm.Mesta;
          
        }



        private void hlButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Mapa.xaml",UriKind.Relative));
        }
    }
}