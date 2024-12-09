using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv10
{
    internal class Cliente
    {

        //o Classe Cliente:
        //▪ Propriedades: Nome, Email.
        //▪ Método: ExibirInformacoes(), que exibe o nome e email do cliente.

        private string nome;
        private string email;

        public Cliente(string nome, string email)
        {
            this.nome = nome;
            this.email = email;
        }

        public void ExibirInfo()
        {
            Console.WriteLine($"Nome: {nome} \n Email: {email}");
        }


    }
}
