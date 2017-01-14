using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektPrzychodnia
{
    class Lekarz: Osoba
    {
        private string specjalnosc;

        public Lekarz(string imieNazwisko, string specjalnosc):base(imieNazwisko)
        {
            this.specjalnosc = specjalnosc;
        }

        public override string ToString()
        {
            return string.Format("Lekarz: imie i nazwisko: {0}, specjalnosc: {1}", imieNazwisko, specjalnosc);
        }
    }
}
