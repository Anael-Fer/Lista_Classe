using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace atv7
{
    internal class ContaCorrente
    {


        //● A classe ContaCorrente tem os campos privados número e dígito, ambos inteiros, o campo agência do
        //tipo Agencia e o campo saldo(double).Crie também um método depositar que receba um parâmetro
        //double com o valor do depósito e aumente o saldo da conta. Crie também um método "sacar" que
        //receba um parâmetro double com o valor do saque e diminua o saldo da conta. A conta não pode ficar
        //negativa.Crie, finalmente, um método "ConsultarSaldo" que retorna uma String contendo o número
        //da conta corrente com dígito, o número da agência com dígito e o saldo da conta corrente.


        // Campos Privados
        private int numero;
        private int digito;
        Agencia agencia;
        private double saldo;

        // Construtor
        public ContaCorrente(int numero, int digito, Agencia agencia, double saldo)
        {
            this.numero = numero;
            this.digito = digito;
            this.agencia = agencia;
            this.saldo = saldo;
        }

        // Metodos
        public void Depositar(double valor)
        {
            saldo += valor;
        }

        // Metodos
        public void Sacar(double valor)
        {
            if (valor <= saldo)
                saldo -= valor;
            else
                Console.WriteLine("O saque é maior que o saldo disponivel");
        }

        // Metodos
        public string ConsultarSaldo()
        {
            return $"Conta: {numero}-{digito}, Agência: {agencia.Exibir()}, Saldo: {saldo:F2}";

        }
    }
}   
