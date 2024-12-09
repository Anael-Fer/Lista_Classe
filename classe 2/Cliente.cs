using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Aula_10___Classe
{
    internal class Cliente
    {
        //Campos Privados 
        private string nome;
        private string endereco;
        private string telefone;

        // Propriedade nome
        public string Nome
        {
            get { return nome; }
            set { nome = value; }   
        }

        // Propriedade endereco
        public string Endereco
        {
            get { return endereco; }
            set { endereco = value;  }
        }

        // Propriedade telefone
        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        // Construtor 1 
        public Cliente(string nome, string endereco, string telefone)
        {
            this.nome = nome;
            this.endereco = endereco;
            this.telefone = telefone;
        }

        // Construtor 2
        public Cliente()
        {
            this.nome = "";
            this.endereco = "";
            this.telefone = "";
        }

        // Método para exibir os dados do cliente
        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {nome}, Endereço: {endereco}, Telefone: {telefone}");
        }

    }
}
