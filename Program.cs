/* MEMBROS ESTÁTICOS: - não muda o resultado das operações, por isso não precisa criar um objeto
    Membros de Classe

Independem de Objetos
Não precisam de Objetos para serem chamados
São chamados a partir do próprio nome da classe

    Classes Utilitárias
    -> Math.sqrt(double) = Método estático - Math é a definição de uma classe e a partir dela eu chamo a opeãção dela*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace MembrosEstaticos
{
    class Program
    {
        //static double pi = 3.14;
        static void Main(string[] args)
        {
            // Primeira maneira de realizar o programa, tudo em um mesmo programa

            /*Console.Write("Informe o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Circunferencia(raio);
            double vol = Volume(raio);

            Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + vol.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de Pi: " + pi.ToString("F2",CultureInfo.InvariantCulture));
        }

        static double Circunferencia(double r)
        {
            return 2 * pi * r;
        }

        static double Volume(double r)
        {
            return 4.0 / 3.0 * pi * Math.Pow(r, 3);
        }*/

            // SEGUNDA MANEIRA DE REALIZAR ESTE PROGRAMA - Utilizando uma Classe



            /*Console.Write("Informe o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // A chamada vai ser feita diretamente pelo nome da Classe - Membro estático É INDEPENDENTE DE OBJETO
            // Static - poderão ser chamados sem precisar instanciar um Objeto

            double circ = Calculadora.Circunferencia(raio);
            double vol = Calculadora.Volume(raio);

            Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + vol.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de Pi: " + Calculadora.pi.ToString("F2", CultureInfo.InvariantCulture));*/


            //******************************************************************************************************
            //ler a cotação do dólar e depois um valor em dólares a ser comprado por uma pessoa em reais
            // informar quanto a pessoa irá pagar e considerar o IOF de 6%


            Console.Write("Informe a Cotação do Dólar: ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Informe quantos Dólares você irá comprar: ");
            double compra = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Chamada feita diretamente pela Classe ConversorDeMoeda
            // passa o valor das variáveis
            double resultado = ConversorDeMoeda.Conversao(compra, cotacao);

            Console.WriteLine("O valor a ser pago em Reais é de: " +resultado.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
