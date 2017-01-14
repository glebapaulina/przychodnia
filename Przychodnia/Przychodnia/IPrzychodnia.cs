using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektPrzychodnia
{
    interface IPrzychodnia
    {
        void UstawLekarza(string imieNazwisko, string specjalnosc);
        void DodajDoKolejki(string imieNazwisko, int wiek, string choroba);
        string WykonajPorade();
        string WykonajBadanie();
        int CzasOczekiwania();
        void GenerujRaport();
    }
}
