using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv7
{
    internal class Agencia
    {


        //● A classe Agencia tem os campos privados nome(String), número e dígito do tipo int.

        // Campos Privados
        private string nome;
        private int numero;
        private int digito;

        // Construtor
        public Agencia(string nome, int numero, int digito)
        {
            this.nome = nome;
            this.numero = numero;
            this.digito = digito;
        }

        // Metodos
        public string Exibir()
        {
            return $"{nome}, {numero}, {digito}";
        }

    }
}
