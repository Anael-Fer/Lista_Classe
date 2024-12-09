using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv3
{
    internal class Circulo
    {

        // Campo Privado
        private double raio;

        // Construtor
        public Circulo(double raio)
        {
            this.raio = raio;
        }

        // Propriedade
        public double Raio
        {
            get { return raio; }
            set { raio = value; }
        }

        // Metodos
        public double CalcularArea()
        {
            return Math.PI * Math.Pow(raio, 2);
        }

        // Metodos
        public double CalcularDiametro()
        {
            return 2 * raio;
        }

        // Metodos
        public double CalcularPerimetro() 
        { 
            return 2 * Math.PI * raio;
        }


    }
}
