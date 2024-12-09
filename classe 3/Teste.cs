using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv3
{
    internal class Teste
    {

        static void Main(string[] args)
        {

            Circulo c1 = new Circulo(5);
            Circulo c2 = new Circulo(10);
            Circulo c3 = new Circulo(6);
            Circulo c4 = new Circulo(2);

            Console.WriteLine("Area dos circulos: ");
            Console.WriteLine(c1.CalcularArea());
            Console.WriteLine(c2.CalcularArea());
            Console.WriteLine(c3.CalcularArea());
            Console.WriteLine(c4.CalcularArea());

            Console.WriteLine("Diametro dos circulos: ");
            Console.WriteLine(c1.CalcularDiametro());
            Console.WriteLine(c2.CalcularDiametro());
            Console.WriteLine(c3.CalcularDiametro());
            Console.WriteLine(c4.CalcularDiametro());

            Console.WriteLine("perimetro dos circulos: ");
            Console.WriteLine(c1.CalcularPerimetro());
            Console.WriteLine(c2.CalcularPerimetro());
            Console.WriteLine(c3.CalcularPerimetro());
            Console.WriteLine(c4.CalcularPerimetro());

            Console.ReadLine();

        }
    }
}
