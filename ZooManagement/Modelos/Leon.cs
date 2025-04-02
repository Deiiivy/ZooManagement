﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooManagement.Modelos
{
    public class Leon : Animal
    {
        public Leon(string nombre, int edad) : base(nombre, edad) { }

        public override string HacerSonido()
        {
            return "¡Rugido del león!";
        }
    }
}

