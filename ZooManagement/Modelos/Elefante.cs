using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooManagement.Modelos
{
    public class Elefante : Animal
    {
        public Elefante(string nombre, int edad) : base(nombre, edad) { }

        public override string HacerSonido()
        {
            return "¡Barrito del elefante!";
        }
    }
}
