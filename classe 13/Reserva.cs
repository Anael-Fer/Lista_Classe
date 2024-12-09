using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv13
{
    internal class Reserva
    {

        //• Propriedades: CodigoReserva, Passageiro, Destino, Valor.
        //• Métodos:
        //o Reservar(string passageiro, string destino, decimal valor) para criar uma
        //reserva.
        //o CancelarReserva() para cancelar a reserva e zerar os dados.
        //o ExibirReserva() para exibir os detalhes da reserva.
        //• O construtor deve inicializar o código da reserva automaticamente com um valor único(use um
        //contador estático, por exemplo).

        private int codigoReserva;
        private static int contR = 1;
        private string passageiro;
        private string destino;
        private double valor;

        public Reserva()
        {
            codigoReserva = contR++;
        }

        public void Reservar(string passageiro, string destino, double valor)
        {
            this.passageiro = passageiro;
            this.destino = destino;
            this.valor = valor;
        }

        public void CancelarReserva()
        { 
            passageiro = null;
            destino = null;
            valor = 0;
        }

        public void ExibirReserva()
        {
            Console.WriteLine($"Codigo da reserva: {codigoReserva} \n Passageiro: {passageiro} \n Destino: {destino} \n Valor: {valor}");
        }



    }
}
