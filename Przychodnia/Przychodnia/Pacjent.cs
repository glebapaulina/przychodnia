using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektPrzychodnia
{
    class Pacjent: Osoba
    {
        private int wiek;
        private string choroba;

        public Pacjent(string imieNazwisko, int wiek, string choroba):base(imieNazwisko)
        {
            this.wiek = wiek;
            this.choroba = choroba;          
        }

        public override string ToString()
        {
            return string.Format("Pacjent: imie i nazwisko: {0}, wiek: {1}, choroba: {2}.", imieNazwisko, wiek, choroba);
        }
    }
}
