using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembrosEstaticos
{
    //Terceiro Programa 
    class ConversorDeMoeda
    {
        public static double Iof = 6.0;

        public static double Conversao(double cm, double ct)
        {
            double total = cm * ct;
            return total + total * Iof / 100;
        }
    }
}
