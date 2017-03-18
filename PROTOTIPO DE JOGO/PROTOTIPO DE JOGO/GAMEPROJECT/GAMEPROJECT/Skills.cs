using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace GAMEPROJECT
{
    abstract class Skills
    {
        public static string energia, fome, depre, pop, forca, intel, trab, mascfem, armas, mmff;
        private static int money;

        public static int Money
        {
            get { return Skills.money; }
            set { Skills.money = value; }
        }

        public static string Mmff
        {
            get { return Skills.mmff; }
            set { Skills.mmff = value; }
        }

        public static string Armas
        {
            get { return Skills.armas; }
            set { Skills.armas = value; }
        }

        public static string Mascfem
        {
            get { return Skills.mascfem; }
            set { Skills.mascfem = value; }
        }

        public static string Trab
        {
            get { return Skills.trab; }
            set { Skills.trab = value; }
        }

        public static string Intel
        {
            get { return Skills.intel; }
            set { Skills.intel = value; }
        }

        public static string Forca
        {
            get { return Skills.forca; }
            set { Skills.forca = value; }
        }

        public static string Pop
        {
            get { return Skills.pop; }
            set { Skills.pop = value; }
        }

        public static string Depre
        {
            get { return Skills.depre; }
            set { Skills.depre = value; }
        }

        public static string Fome
        {
            get { return Skills.fome; }
            set { Skills.fome = value; }
        }

        public static string Energia
        {
            get { return Skills.energia; }
            set { Skills.energia = value; }
        }

    }
}
