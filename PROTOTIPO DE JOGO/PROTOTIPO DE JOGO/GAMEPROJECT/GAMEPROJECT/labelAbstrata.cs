using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GAMEPROJECT
{
    abstract class labelAbstrata
    {
        private static string labelNome, labelSecsu;

        public static string LabelSecsu
        {
            get { return labelAbstrata.labelSecsu; }
            set { labelAbstrata.labelSecsu = value; }
        }

        public static string LabelNome
        {
            get { return labelAbstrata.labelNome; }
            set { labelAbstrata.labelNome = value; }
        }
    }
}
