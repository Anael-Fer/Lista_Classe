using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv7
{
    internal class Cliente
    {

        //● A classe Cliente possui os campos privados “nome” e “CPF”, ambos do tipo String, e um campo conta
        //do tipo ContaCorrente.

        // Campos Privados 
        private string nome;
        private string cpf;
        ContaCorrente contaCorrente;

        // Construtor
        public Cliente(string nome, string cpf, ContaCorrente contaCorrente)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.contaCorrente = contaCorrente;
        }
    }
}
