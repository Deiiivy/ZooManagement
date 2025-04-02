using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooManagement.Modelos
{
    public abstract class Animal
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public Animal(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        public abstract string HacerSonido();
    }
}

