using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProjektPrzychodnia
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Przychodnia przychodnia = new Przychodnia();
        public MainWindow()
        {
            
            InitializeComponent();
            PanelPacjent.Visibility = Visibility.Hidden;
       
        }

        private void UstawL_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (danelekarza.Text.Length != 0 && specjalnosc.Text.Length  != 0)
                przychodnia.UstawLekarza(danelekarza.Text, specjalnosc.Text);
                PanelPacjent.Visibility = Visibility.Visible;
                danelekarza.Clear();
                specjalnosc.Clear();
            }
            catch
            {
                MessageBox.Show("Wprowadź dane");
            }
        }
        private void  dopiszdokolejki_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (danepacjenta.Text.Length != 0 && choroba.Text.Length != 0 && Convert.ToInt16(wiek.Text) > 0 && Convert.ToInt16(wiek.Text) < 120 )
                {
                    przychodnia.DodajDoKolejki(danepacjenta.Text, Convert.ToInt16(wiek.Text), choroba.Text);   
                    MessageBox.Show("Zapisano pacjenta: " + " " + danepacjenta.Text + " " + Convert.ToInt16(wiek.Text) + " " + choroba.Text);     
                }
                else
                {
                    throw new Exception();
                }
                kolejka.Text = przychodnia.ToString();
                Clear();
            }
            catch
            {
                MessageBox.Show("Niepoprawne dane");
            }
         
        }

        private void porada_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBox.Show(przychodnia.WykonajPorade());
                kolejka.Text = przychodnia.ToString();
            }
            catch
            {
                MessageBox.Show("Brak pacjentów w kolejce.");
            }
        }

        private void badanie_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBox.Show(przychodnia.WykonajBadanie());
                kolejka.Text = przychodnia.ToString();
            }
            catch
            {
                MessageBox.Show("Brak pacjentów w kolejce.");
            }
        }

        private void Clear()
        {
            danepacjenta.Clear();
            wiek.Clear();
            choroba.Clear();          
        }

        private void raport_Click(object sender, RoutedEventArgs e)
        {
            przychodnia.GenerujRaport();
            MessageBox.Show("Wygenerowano raport");
        }
    }
}
