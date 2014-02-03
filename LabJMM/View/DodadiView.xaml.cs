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

namespace LabJMM.View
{
    public partial class DodadiView : UserControl
    {
        public DodadiView()
        {
            InitializeComponent();
        }

        private void Dodadi_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Mesto mesto = new Mesto();

            mesto.Name = tbName.Text;
            mesto.Opis = tbOpis.Text;
            mesto.KorX = Convert.ToDouble(tbKorX.Text);
            mesto.KorY = Convert.ToDouble(tbKorY.Text);
            mesto.Posetiteli = Convert.ToInt32(tbPosetiteli.Text);

            tbName.Text = "";
            tbOpis.Text = "";
            tbKorX.Text = "";
            tbKorY.Text = "";
            tbPosetiteli.Text = "";

            Global.vm.Mesta.Add(mesto);
        }
    }
}
