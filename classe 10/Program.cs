using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace atv10
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //10.Desenvolva duas classes, Pedido e Cliente como se segue e faça o que se pede:

            //Teste o uso de suas classes, criando um pedido e um cliente.Execute os métodos das classes.

            Cliente cliente = new Cliente("João Silva", "joao@gmail.com");
            Pedido pedido = new Pedido(1001, cliente, 350.75);
            pedido.ExibirResumo();
            Console.ReadLine();

        }

    }
}
