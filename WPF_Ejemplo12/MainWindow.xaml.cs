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

namespace WPF_Ejemplo12
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

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            Blank.Visibility=Visibility.Hidden;
            IRojo.Visibility = Visibility.Visible;
            IAmbar.Visibility = Visibility.Hidden;
            IVerde.Visibility = Visibility.Hidden;
        }

        private void RadioButton_Click_1(object sender, RoutedEventArgs e)
        {
            Blank.Visibility = Visibility.Hidden;
            IRojo.Visibility = Visibility.Hidden;
            IAmbar.Visibility = Visibility.Visible;
            IVerde.Visibility = Visibility.Hidden;
        }

        private void RadioButton_Click_2(object sender, RoutedEventArgs e)
        {
            Blank.Visibility=Visibility.Hidden;
            IRojo.Visibility = Visibility.Hidden;
            IAmbar.Visibility = Visibility.Hidden;
            IVerde.Visibility = Visibility.Visible;
        }
    }
}
