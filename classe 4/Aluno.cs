using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace atv4
{
    internal class Aluno
    {

        private string nome;
        private string matricula;
        private double[] notas = new double[10]; 

        public Aluno(string nome, string matricula, double[] notas)
        {
            this.nome = nome;
            this.matricula = matricula;
            this.notas = notas;
        }

        public double[] Notas
        {
            get { return notas; }
            set { notas = value; }
        }


        public double Media()
        {
            double soma = 0, media = 0;

            for(int i = 0; i < notas.Length; i++)
            {
                soma += notas[i];
            }

            media = soma / notas.Length;

            return media;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Matrícula: {matricula}");
            Console.WriteLine($"Média: {Media():F2}");
        }

    }
}
