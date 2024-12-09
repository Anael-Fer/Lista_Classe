using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv11
{
    internal class Motor
    {

        //• Classe Motor:
        //o Propriedades: Tipo(ex.: "Gasolina", "Elétrico") e Potencia.
        //o Método: ExibirDetalhes(), que exibe o tipo e a potência do motor.

        private string tipo;
        private double potencia;

        public Motor(string tipo, double potencia)
        {
            this.tipo = tipo;
            this.potencia = potencia;
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"Tipo: {tipo} \n Potência: {potencia}");
        }

       
    }
}
