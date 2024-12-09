using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv14
{
    internal class Quarto
    {

        //• Classe Quarto:
        //o Propriedades: Numero, Tipo(ex.: "Simples", "Luxo"), PrecoPorDia.
        //o Método: ExibirDetalhes(), que exibe o número e o tipo do quarto.

        private int numero;
        private string tipo;
        private double precoPorDia;

        public Quarto(int numero, string tipo, double precoPorDia)
        {
            this.numero = numero;
            this.tipo = tipo;
            this.precoPorDia = precoPorDia;
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"Quarto Nº: {numero}, Tipo: {tipo}, Preço por Dia: R$ {precoPorDia:F2}");
        }

        public double PrecoPorDia
        {
            get { return precoPorDia; }
        }
    }
}
