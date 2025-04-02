using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooManagement.Modelos
{
    public class Serpiente : Animal
    {
        public Serpiente(string nombre, int edad) : base(nombre, edad) { }

        public override string HacerSonido()
        {
            return "¡Ssssss de la serpiente!";
        }
    }
}
