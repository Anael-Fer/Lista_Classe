using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace atv6
{
    internal class Produto
    {
        // Campos Privados
        private string nome;
        private double preco;
        Etiqueta etiqueta;

        // Construtor 1
        public Produto(string nome, double preco, Etiqueta etiqueta)
        {
            this.nome = nome;
            this.preco = preco;
            this.etiqueta = etiqueta;
        }

        // Construtor 2
        public Produto(string nome, double preco, string marca, string tamanho)
        {
            this.nome = nome;
            this.preco = preco;
            this.etiqueta = new Etiqueta(marca, tamanho);
        }


        //● Crie a classe Produto com os campos privados nome(string), preço(double) e etiqueta, do tipo
        //Etiqueta.Crie um construtor, que receba como parâmetro o nome, preço e um objeto Etiqueta.Crie
        //outro construtor, que receba o nome e preço do produto, e também a marca e tamanho da etiqueta
        //como parâmetros(o objeto Etiqueta deve ser instanciado no construtor).

        // Métodos
        public void ExibirDetalhes()
        {
            Console.WriteLine($"Produto: {nome}, Preço: {preco:F2}, Marca: {etiqueta.Marca},: { etiqueta.Tamanho}");
        }

    }
}
