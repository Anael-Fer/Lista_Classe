using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv10
{
    internal class Pedido
    {

        //o Classe Pedido:
        //▪ Propriedades: NumeroPedido, Cliente(um objeto da classe Cliente), ValorTotal.

        //▪ Métodos:
        //▪ ExibirResumo() exibe o número do pedido, o cliente e o valor total.
        //o O construtor de Pedido deve receber um objeto Cliente como parâmetro e associá-lo ao
        //pedido.

        private int NumeroPedido;
        Cliente cliente;
        private double ValorTotal;

        public Pedido(int NumeroPedido, Cliente cliente, double ValorTotal)
        {
            this.NumeroPedido = NumeroPedido;
            this.cliente = cliente;
            this.ValorTotal = ValorTotal;
        }
        public void ExibirResumo()
        {
            Console.WriteLine($"Pedido Nº: {NumeroPedido}");
            cliente.ExibirInfo();
            Console.WriteLine($"Valor Total: R$ {ValorTotal:F2}");
        }



    }
}
