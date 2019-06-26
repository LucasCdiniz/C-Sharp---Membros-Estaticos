using System;

namespace MembrosEstaticos
{
    class Calculadora
    {
        // Static - poderão ser chamados sem precisar instanciar um Objeto
        public static double pi = 3.14;

        public static double Circunferencia(double r)
        {
            return 2 * pi * r;
        }

        public static double Volume(double r)
        {
            return 4.0 / 3.0 * pi * Math.Pow(r, 3);
        }
    }
}
