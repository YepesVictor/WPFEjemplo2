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
using WPFEjemplo2;

namespace WPF_Ejemplo9
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public UnirNombre unirNombreApellido;
        public MainWindow()
        {
            InitializeComponent();
            unirNombreApellido=new UnirNombre { Nombre = "Victor", Apellido="Yepes" };
            this.DataContext = unirNombreApellido;
        }
    }
}
