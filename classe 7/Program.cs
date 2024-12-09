using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv7
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Crie as classes “Cliente”, “ContaCorrente” e “Agencia” conforme abaixo:

            //● Para testar crie uma classe CaixaEletronico, que irá conter o método Main.No Main instancie um
            //cliente com os seguintes dados:

            //        Nome: Ademar da Silva
            //        - CPF: 123231518 - 12
            //        - Conta Corrente: 1234, Dígito: 4
            //        - Agência: Pampulha, 7890, Dígito: 5
            //        - Saldo Inicial: R$150.00

            //Faça as seguintes operações:

            //        -sacar 140.0
            //        - consultar saldo
            //        - sacar 200.0
            //        - consultar saldo
            //        - depositar 25.45


            Agencia agencia = new Agencia("Pampulha", 7890, 5);
            ContaCorrente conta = new ContaCorrente(1234, 4, agencia, 150.00);
            Cliente cliente = new Cliente("Ademar da Silva", "123231518-12", conta);

            conta.Sacar(140.00);
            Console.WriteLine(conta.ConsultarSaldo());
            conta.Sacar(200.00);
            Console.WriteLine(conta.ConsultarSaldo());
            conta.Depositar(25.45);
            Console.WriteLine(conta.ConsultarSaldo());

            Console.ReadLine();
        }
    }
}
