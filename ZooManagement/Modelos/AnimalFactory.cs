using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooManagement.Modelos
{
    public static class AnimalFactory
    {
        public static Animal CrearAnimal(string tipo, string nombre, int edad)
        {
            if (tipo == "León")
            {
                return new Leon(nombre, edad);
            }
            else if (tipo == "Elefante")
            {
                return new Elefante(nombre, edad);
            }
            else if (tipo == "Serpiente")
            {
                return new Serpiente(nombre, edad);
            }
            else
            {
                throw new ArgumentException("Tipo de animal no válido");
            }
        }
    }
}
