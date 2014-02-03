using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using LabJMM.Model;
using LabJMM.Code;
using System.Collections.ObjectModel;

namespace LabJMM.View
{
    public partial class PrikazView : UserControl
    {
        public PrikazView()
        {
            InitializeComponent();
        }

        private void Delete_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                var mesto = button.DataContext as Mesto;
                Global.vm.Mesta.Remove(mesto);
            }
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var listbox = sender as ListBox;
            if (listbox != null && listbox.SelectedIndex!=-1)
            {
                var mesto = listbox.SelectedItem as Mesto;
                Global.gMesto = mesto;
                (Application.Current.RootVisual as PhoneApplicationFrame).Navigate(new Uri("/DetailPage.xaml", UriKind.Relative));
            }
        }
    }
}
