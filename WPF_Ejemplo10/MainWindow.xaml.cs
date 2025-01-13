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

namespace WPF_Ejemplo10
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Poblacion> listaPoblacion = new List<Poblacion>();
            listaPoblacion.Add(new Poblacion() { Poblacion1 = "Madrid", Poblacion2 = "Barcelona", Temperatura1 = 15, Temperatura2 = -17});
            listaPoblacion.Add(new Poblacion() { Poblacion1 = "Valencia", Poblacion2 = "Pamplona", Temperatura1 = 22, Temperatura2 = 16 });
            listaPoblacion.Add(new Poblacion() { Poblacion1 = "Malaga", Poblacion2 = "Castellón", Temperatura1 = 23, Temperatura2 = 20 });
            listaPoblacion.Add(new Poblacion() { Poblacion1 = "Logroño", Poblacion2 = "Zaragoza", Temperatura1 = 14, Temperatura2 = -13 });
            listaPoblaciones.ItemsSource = listaPoblacion;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(listaPoblaciones.SelectedItem != null)
            {
                MessageBox.Show((listaPoblaciones.SelectedItem as Poblacion).Poblacion1 + " " +
                (listaPoblaciones.SelectedItem as Poblacion).Temperatura1 + "ºC " +
                (listaPoblaciones.SelectedItem as Poblacion).Poblacion2 + " " +
                (listaPoblaciones.SelectedItem as Poblacion).Temperatura2 + "ºC.");
            }
            else
            {
                MessageBox.Show("Seleccione un elemento de la lista superior");
            }
           
        }

        private void TextBlock_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (listaPoblaciones.SelectedItem != null)
            {
                MessageBox.Show((listaPoblaciones.SelectedItem as Poblacion).Poblacion1 + " " +
                (listaPoblaciones.SelectedItem as Poblacion).Temperatura1 + "ºC " +
                (listaPoblaciones.SelectedItem as Poblacion).Poblacion2 + " " +
                (listaPoblaciones.SelectedItem as Poblacion).Temperatura2 + "ºC.");
            }
            else
            {
                MessageBox.Show("Seleccione un elemento de la lista superior");
            }
        }
    }
}
