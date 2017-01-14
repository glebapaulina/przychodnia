using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProjektPrzychodnia
{
    class Przychodnia : IPrzychodnia
    {
        private Lekarz lekarz;
        private Queue<Pacjent> pacjenci = new Queue<Pacjent>();


        public void UstawLekarza(string imieNazwisko, string specjalnosc)
        {
            lekarz = new Lekarz(imieNazwisko, specjalnosc);
            
        }
        public void DodajDoKolejki(string imieNazwisko, int wiek, string choroba)
        {
            pacjenci.Enqueue(new Pacjent(imieNazwisko, wiek, choroba));
           
        }
        public string WykonajPorade()
        {
            return string.Format("Wykonano poradę! {0}", pacjenci.Dequeue().ToString());
        }
        public string WykonajBadanie()
        {
            return string.Format("Wykonano badanie! {0}", pacjenci.Peek().ToString());
        }
        public int CzasOczekiwania()
        {
            return (int)Math.Floor((double)pacjenci.Count() / 4);
        }
        public override string ToString()
        {
            string result = "";
            result += String.Format(lekarz.ToString() + Environment.NewLine + "Pacjenci w kolejce:" + Environment.NewLine);
            foreach(var element in pacjenci)
            {
                result += String.Format(element.ToString() + Environment.NewLine);
            }
            result += String.Format("Czas oczekiwania: {0}", CzasOczekiwania() + Environment.NewLine);

            return result;
        }
        public void GenerujRaport()
        {
            string nazwa ="Raport"+ DateTime.Now.ToString("HHmmddMMyyyy") + ".txt";

            using (StreamWriter sw = new StreamWriter(nazwa))
            {
                sw.Write(ToString());             
            }
            
            
        }
        bool CzyLekarz()
        {
            if (lekarz != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}
