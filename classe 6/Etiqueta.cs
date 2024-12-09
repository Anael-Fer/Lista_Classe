using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace atv6
{
    internal class Etiqueta
    {

        // Campos Privados 
        private string marca;
        private string tamanho;

        // Construtor
        public Etiqueta(string marca, string tamanho)
        {
            this.marca = marca;
            this.tamanho = tamanho;
        }

        // Propriedades
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public string Tamanho
        {
            get { return tamanho; }
            set { tamanho = value; }
        }

    }
}
