using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv13
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //3.Desenvolva uma classe Reserva para gerenciar reservas de passagens.

            //Crie um sistema que permita criar, exibir e cancelar reservas.

            Reserva reserva = new Reserva();
            Reserva reserva1 = new Reserva();
            reserva.Reservar("João Silva", "Rio de Janeiro", 450.50);
            reserva1.Reservar("João Silva", "Rio de Janeiro", 450.50);
            reserva.ExibirReserva();
            reserva1.ExibirReserva();
            reserva.CancelarReserva();
            Console.WriteLine("\nReserva Cancelada:");
            reserva.ExibirReserva();

            Console.ReadLine();


        }
    }
}
