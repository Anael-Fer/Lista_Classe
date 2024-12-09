using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace atv11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //11.Desenvolva duas classes, Carro e Motor como se segue e faça o que se pede:

            //Teste o uso de suas classes, criando um pedido e um cliente.Execute os métodos das classes.

            Motor motor = new Motor("Gasolina", 150);
            Carro carro = new Carro("Toyota", "Corolla", motor);
            carro.ExibirDetalhes();

            Console.ReadLine();

        }
    }
}
