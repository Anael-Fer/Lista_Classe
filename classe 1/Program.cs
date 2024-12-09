using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_10___Classe
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //01.Escreva um programa para cadastrar um cliente em uma loja.As informações necessárias são: “nome”,
            //“endereço” e “telefone”. Crie uma Cliente com todos campos privados, dois métodos construtores diferentes
            //e propriedades. No Main, crie três clientes, e utilize todas as propriedades.

            Cliente cliente1 = new Cliente("Renato", "Rua A", "11111-1111");
            Cliente cliente2 = new Cliente("Ana", "Rua B", "22222-2222");
            Cliente cliente3 = new Cliente();

            cliente1.ExibirDados();
            cliente2.ExibirDados();
            cliente3.ExibirDados();

            cliente3.Nome = "Carlos";
            cliente3.Endereco = "Rua C";
            cliente3.Telefone = "33333-3333";

            cliente1.ExibirDados();
            cliente2.ExibirDados();
            cliente3.ExibirDados();

            Console.ReadLine();
        }
    }
}
