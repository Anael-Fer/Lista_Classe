using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv12
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Crie um vetor de 5 alunos no main() e implemente um método para exibir as informações de todos.

            Aluno[] aluno = new Aluno[1];

            string nome;
            int matricula;
            double[] notas = new double[5];
            int cont = 0;

            do
            {
                Console.WriteLine("Digite o seu nome: ");
                nome = Console.ReadLine();

                Console.WriteLine("Digite a sua matricula: ");
                matricula = int.Parse(Console.ReadLine());

                for (int i = 0; i < notas.Length; i++)
                {
                    Console.WriteLine($"Digite a sua {i + 1}° nota: ");
                    notas[i] = double.Parse(Console.ReadLine());
                }

                aluno[cont++] = new Aluno(nome, matricula, notas);

            } while (cont < aluno.Length);

            for(int i = 0; i < aluno.Length; i++)
            {
                aluno[i].ExibirInfo();
            }

            Console.ReadLine();

        }
    }
}
