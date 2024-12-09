using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace atv12
{
    internal class Aluno
    {

        //12.Desenvolva uma classe Aluno para gerenciar informações acadêmicas.
        //• Propriedades: Nome, Matricula, Notas(vetor de 5 notas).
        //• Métodos:
        // o AdicionarNota(int indice, double nota) para adicionar uma nota em uma posição
        //específica.
        //o CalcularMedia() para calcular a média das notas.
        //o ExibirInformacoes() para exibir o nome, matrícula e média.

        private string nome;
        private int matricula;
        private double[] notas = new double[5];

        public Aluno(string nome, int matricula, double[] notas)
        {
            this.nome = nome;
            this.matricula = matricula;
            this.notas = notas;
        }

        public double CalcularMedia()
        {
            double media = 0, soma = 0;


            for(int i = 0; i < notas.Length; i++)
            {
                soma += notas[i];
            }

            media = soma / notas.Length;

            return media;

        }

        public void ExibirInfo()
        {
            Console.WriteLine($"Nome: {nome} \n Matricula: {matricula} \n " + "Média: " + CalcularMedia());
        }


    }
}
