using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //04.Crie uma classe "Aluno" com os campos "nome", "matricula" e "notas"(array de double com tamanho10).
            //Todos os campos devem ser privados.Adicione um método para calcular e retornar a média das notas do aluno.
            //Implemente uma classe Teste(com método Main), crie dois alunos e imprima a média das notas dos alunos.

            double[] notas1 = { 8, 7, 9, 6, 7, 8, 10, 6, 5, 9 };
            double[] notas2 = { 7, 6, 5, 8, 9, 7, 6, 8, 9, 7 };

            Aluno aluno1 = new Aluno("Ana", "123456", notas1);
            Aluno aluno2 = new Aluno("Roberto", "456789", notas2);

            aluno1.ExibirDados();
            aluno2.ExibirDados();

            Console.ReadLine();
        }
    }
}
