using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Ejemplo10
{
    public class Poblacion
    {
        private string poblacion1, poblacion2;
        private int temperatura1, temperatura2;


        public string Poblacion1 { get => poblacion1; set => poblacion1 = value; }
        public string Poblacion2 { get => poblacion2; set => poblacion2 = value; }
        public int Temperatura1 { get => temperatura1; set => temperatura1 = value; }
        public int Temperatura2 { get => temperatura2; set => temperatura2 = value; }
        public int DiferenciaTemp { 
            get 
            { 
                return Math.Abs(Temperatura1 - Temperatura2); 
            }
            set { }
        }
    }
}
