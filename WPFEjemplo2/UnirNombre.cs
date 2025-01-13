using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace WPFEjemplo2
{
    public class UnirNombre : INotifyPropertyChanged
    {
        private string nombre, apellido, nombreCompleto;

        public string Nombre 
        { 
            get => nombre; 
            set 
            { 
                nombre = value; 
                OnPropertyChanged("NombreCompleto"); 
            } 
        }
        public string Apellido { 
            get => apellido; 
            set 
            { 
                apellido = value;
                OnPropertyChanged("NombreCompleto");
            } 
        }
        public string NombreCompleto
        {
            get
            {
                nombreCompleto = Nombre + " " + Apellido;
                return nombreCompleto;
            }
            set { }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null) { PropertyChanged(this, new PropertyChangedEventArgs(property)); }
        }

    }

}
