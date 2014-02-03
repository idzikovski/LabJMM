using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.ComponentModel;

namespace LabJMM.Model
{
    class Mesto : INotifyPropertyChanged
    {
        public string Name { get; set; }

        public string Opis { get; set; }

        public double KorX { get; set; }

        public double KorY { get; set; }

        private int _posetiteli;
        public int Posetiteli
        {
            get
            {
                return _posetiteli;
            }
            set
            {
                _posetiteli = value;
                RaisePropertyChanged("Posetiteli");
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }


        // Create a copy of an accomplishment to save.
        // If your object is databound, this copy is not databound.
        public Mesto GetCopy()
        {
            Mesto copy = (Mesto)this.MemberwiseClone();
            return copy;
        }

    }
}
