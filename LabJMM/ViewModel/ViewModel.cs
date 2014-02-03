using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabJMM.Model;
using System.Collections.ObjectModel;

namespace LabJMM.ViewModelNamespace
{
    class ViewModel
    {
        public ObservableCollection<Mesto> Mesta { get; set; }

        public void GetNastani()
        {
            GetDefaultNastani();    
        }

        private void GetDefaultNastani()
        {
            ObservableCollection<Mesto> a = new ObservableCollection<Mesto>();

            a.Add(new Mesto() { Name = "Finki", Opis = "Fakultet", KorX = 42.004967, KorY = 21.408273, Posetiteli = 33 });
            a.Add(new Mesto() { Name = "Feit", Opis = "Fakultet", KorX = 42.004967, KorY = 21.408273, Posetiteli = 43 });
            a.Add(new Mesto() { Name = "Park", Opis = "Mesto za setanje", KorX = 42.004551, KorY = 21.421289, Posetiteli = 330 });
            a.Add(new Mesto() { Name = "Doma", Opis = "Kuka", KorX = 44.444, KorY = 42.004967, Posetiteli = 4 });
            a.Add(new Mesto() { Name = "Plostad", Opis = "Soborno mesto", KorX = 42.004967, KorY = 21.408273, Posetiteli = 79 });
            a.Add(new Mesto() { Name = "Stadion", Opis = "Arena", KorX = 42.00585, KorY = 21.425688, Posetiteli = 79 });

           
            Mesta = a;
        }
    }

}
