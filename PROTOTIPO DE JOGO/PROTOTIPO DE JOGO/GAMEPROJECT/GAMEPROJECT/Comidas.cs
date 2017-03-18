using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GAMEPROJECT
{
    abstract class Comidas
    {
        static public int bebida, comida;

        public static int Comida
        {
            get { return Comidas.comida; }
            set { Comidas.comida = value; }
        }

        public static int Bebida
        {
            get { return Comidas.bebida; }
            set { Comidas.bebida = value; }
        }
    }
}
