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

namespace WPF_Ejemplo11
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Capitales> ListaCapitales = new List<Capitales>();

            ListaCapitales.Add(new Capitales { NombreCapital = "Madrid" });
            ListaCapitales.Add(new Capitales { NombreCapital = "Logroño" });
            ListaCapitales.Add(new Capitales { NombreCapital = "Pamplona" });
            ListaCapitales.Add(new Capitales { NombreCapital = "Burgos" });
            ListaCapitales.Add(new Capitales { NombreCapital = "Soria" });

            Capitales.ItemsSource = ListaCapitales;
        }

        private void TodasCap_Checked(object sender, RoutedEventArgs e)
        {
            Madrid.IsChecked = true;
            Logroño.IsChecked = true;
            Pamplona.IsChecked = true;
            Burgos.IsChecked = true;
            Soria.IsChecked = true;
        }

        private void TodasCap_Unchecked(object sender, RoutedEventArgs e)
        {
            Madrid.IsChecked = false;
            Logroño.IsChecked = false;
            Pamplona.IsChecked = false;
            Burgos.IsChecked = false;
            Soria.IsChecked = false;
        }

        private void Individual_Checked(object sender, RoutedEventArgs e)
        {
            if (Madrid.IsChecked == true&& Logroño.IsChecked==true &&
                Pamplona.IsChecked==true && Burgos.IsChecked==true &&
                Soria.IsChecked == true)
            {
                TodasCap.IsChecked = true;
            }
            else
            {
                TodasCap.IsChecked = null;
            }
        }

        private void Individual_Unchecked(object sender, RoutedEventArgs e)
        {
            if (Madrid.IsChecked == false && Logroño.IsChecked == false &&
               Pamplona.IsChecked == false && Burgos.IsChecked == false &&
               Soria.IsChecked == false)
            {
                TodasCap.IsChecked = false;
            }
            else
            {
                TodasCap.IsChecked = null;
            }
        }
    }
    public class Capitales
    {
        public string NombreCapital { get; set; }
    }
}
