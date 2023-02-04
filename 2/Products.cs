using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tascN2_Classes
{
    internal class Hero
    {
        private int products1;
        private int products2;
        private int products3;

        public int Products1 { get => products1; set => products1 = value; }
        public int Products2 { get => products2; set => products2 = value; }
        public int Products3 { get => products3; set => products3 = value; }

        public Hero(int products1, int products2, int products3)
        {
            Products1 = products1;
            Products2 = products2;
            Products3 = products3;

        }

        public override string ToString()
        {
            return "Продали за день: ( 1 участник " + Products1 + "продукции, 2 участник " + Products2 + "продукции , 3 участник " + Products3 + "продукции )";
        }
    }
}