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

namespace WPF_Ejemplo4
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           // MessageBox.Show("Has pulsado el botón Enviar 2", "Mensaje", MessageBoxButton.OK, MessageBoxImage.Information);
            Console.WriteLine("Has pulsado el boton enviar 2");

        }

        private void Panel_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Has pulsado el Panel", "Mensaje", MessageBoxButton.OK, MessageBoxImage.Information);
            Console.WriteLine("Has pulsado el panel");
        }

        private void Panel_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine("Has pulsado el panel");
         //   MessageBox.Show("Has pulsado el Panel", "Mensaje", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
