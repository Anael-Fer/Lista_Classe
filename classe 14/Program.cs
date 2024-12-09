using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv14
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //14.Desenvolva duas classes, Quarto e Reserva como se segue e faça o que se pede:

            //Crie uma reserva vinculada a um quarto e calcular o valor total.

            Quarto quarto = new Quarto(101, "Luxo", 300.00);
            Reserva reserva = new Reserva("Ana Clara", quarto, 5);
            reserva.ExibirReserva();

            Console.ReadLine();
        }
    }
}
