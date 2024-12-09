using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 05.Implemente uma classe Pessoa com os seguintes atributos privados:
            //-Nome
            //- Ano de nascimento
            //-Telefone
            //- Mês de aniversário

            //Faça um programa que contenha um menu de opções para:
            //0 – sair do programa
            //1 – cadastrar pessoas
            //2 – mostrar os aniversariantes do mês e suas idades

            //O método MostrarAniversariantes deve receber um mês como parâmetro e mostrar na tela todas as pessoas
            //cadastradas que fazem aniversário naquele mês e sua idade(anos).Você pode utilizar um vetor de pessoas
            //para instanciar os objetos da sua classe.

            int opcao;

            Pessoa[] pessoas = new Pessoa[2];
            int contPessoas = 0;

            do
            {
                Console.WriteLine("\nMenu de opções:");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("1 - Cadastrar pessoa");
                Console.WriteLine("2 - Mostrar aniversariantes do mês");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                if(opcao == 1)
                {

                        Console.WriteLine("Digite seu nome: ");
                        string nome = Console.ReadLine();

                        Console.WriteLine("Digite seu ano de nascimento: ");
                        int ano_nascimento = int.Parse(Console.ReadLine());

                        Console.Write("Digite o telefone: ");
                        string telefone = Console.ReadLine();

                        Console.Write("Digite o mês de aniversário (1-12): ");
                        int mesAniversario = int.Parse(Console.ReadLine());

                        if (mesAniversario < 1 || mesAniversario > 12)
                        {
                            Console.WriteLine("Mês inválido! Cadastro cancelado.");
                        }
                        else
                        {
                            pessoas[contPessoas] = new Pessoa(nome, ano_nascimento, telefone, mesAniversario);
                            contPessoas++;
                            Console.WriteLine("Pessoa cadastrada com sucesso!");
                        }
                }
                else if (opcao == 2)
                {
                    Console.Write("Digite o mês (1-12) para listar aniversariantes: ");
                    int mes = int.Parse(Console.ReadLine());
                    Pessoa.MostrarAniversariantes(pessoas, mes);
                }
                else
                    Console.WriteLine("Opção inválida! Tente novamente.");

            } while (opcao != 0);

            Console.ReadLine();

        }
    }
}
