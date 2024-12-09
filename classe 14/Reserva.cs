using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv14
{
    internal class Reserva
    {

        //• Classe Reserva:
        //o Propriedades: Cliente, Quarto(um objeto da classe Quarto), DiasReservados.
        //o Método: CalcularValorTotal() calcula o valor total da reserva com base no preço por dia e
        //na quantidade de dias.
        //• O construtor de Reserva deve inicializar o cliente e o quarto recebendo objetos das classes
        //correspondentes.



        private string cliente;
        Quarto quarto;
        private int diasReservados;

        public Reserva(string cliente, Quarto quarto, int diasReservados)
        {
            this.cliente = cliente;
            this.quarto = quarto;
            this.diasReservados = diasReservados;
        }

        public double CalcularValorTotal()
        {
            return quarto.PrecoPorDia * diasReservados;
        }

        public void ExibirReserva()
        {
            Console.WriteLine($"Cliente: {cliente}");
            quarto.ExibirDetalhes();
            Console.WriteLine($"Dias Reservados: {diasReservados}, Valor Total: R${CalcularValorTotal():F2}");
        }

    }
}
