using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace atv5
{
    internal class Pessoa
    {

        private string nome;
        private int ano_nascimento;
        private string telefone;
        private int mes_aniversario;

        public Pessoa(string nome, int ano_nascimento, string telefone, int mes_aniversario)
        {
            this.nome = nome;
            this.ano_nascimento = ano_nascimento;
            this.telefone = telefone;
            this.mes_aniversario = mes_aniversario;
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }


        public int CalcularIdade()
        {
            return DateTime.Now.Year - ano_nascimento;
        }

        //O método MostrarAniversariantes deve receber um mês como parâmetro e mostrar na tela todas as pessoas
        //cadastradas que fazem aniversário naquele mês e sua idade(anos).Você pode utilizar um vetor de pessoas
        //para instanciar os objetos da sua classe.

        public static void MostrarAniversariantes(Pessoa[] pessoas, int mes)
        {
            for(int i = 0; i < pessoas.Length; i++)
            {

                if (pessoas[i].mes_aniversario == mes)
                {
                    Console.WriteLine($"Nome: {pessoas[i].Nome} - Idade: {pessoas[i].CalcularIdade()}");
                }
                else
                    Console.WriteLine("Não há aniversariantes nesse mês");

            }
        }


    }
}
