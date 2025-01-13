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

namespace WPFEjemplo2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Creamos el contenedor Grid
            Grid gridBoton = new Grid();

            //Indicamos que el contenido va a estar dentro del Grid
            this.Content = gridBoton;

            //Creamos el boton
            Button btnEnviar = new Button();

            //Agregamos el boton al grid
            //    gridBoton.Children.Add(btnEnviar);

            //Creamos el contenedor WrapPanel
            WrapPanel wrapoBoton = new WrapPanel();

            //Creamos ahora los tres bloques de texto
            //textBlock1
            TextBlock txtBlock1 = new TextBlock();
            txtBlock1.Text = "Enviar";
            wrapoBoton.Children.Add(txtBlock1);

            //textBlock2
            TextBlock txtBlock2 = new TextBlock();
            txtBlock2.Text = "Comprobar";
            wrapoBoton.Children.Add(txtBlock2);

            //textBlock3
            TextBlock txtBlock3 = new TextBlock();
            txtBlock3.Text = "Salir";
            wrapoBoton.Children.Add(txtBlock3);

            //El boton btnEnviar tiene como contenido el wrapBoton
            btnEnviar.Content = wrapoBoton;

            //Agregamos el boton al gridBoton
            gridBoton.Children.Add(btnEnviar);

            btnEnviar.Width = 150;
            btnEnviar.Height = 75;

         //   txtBlock1.Foreground=Brushes.Yellow;
            txtBlock1.Foreground = new SolidColorBrush(Colors.Yellow);
            txtBlock2.Foreground = new SolidColorBrush(Colors.Purple);
            txtBlock3.Foreground = new SolidColorBrush(Colors.BlueViolet);

            btnEnviar.Background = new SolidColorBrush(Colors.Blue);
            txtBlock1.Background = new SolidColorBrush(Colors.Red);
            txtBlock2.Background = new SolidColorBrush(Colors.LightGreen);
            txtBlock3.Background = new SolidColorBrush(Colors.White);
        }
    }
}
