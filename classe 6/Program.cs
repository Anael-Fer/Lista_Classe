using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace atv6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //06.Crie as seguintes classes:
            //● Crie a classe Etiqueta com os campos privados marca(string) e tamanho(string). Crie seu construtor,
            //que recebe parâmetros para inicializar os campos.

            //● Crie a classe Produto com os campos privados nome(string), preço(double) e etiqueta, do tipo
            //Etiqueta.Crie um construtor, que receba como parâmetro o nome, preço e um objeto Etiqueta.Crie
            //outro construtor, que receba o nome e preço do produto, e também a marca e tamanho da etiqueta
            //como parâmetros(o objeto Etiqueta deve ser instanciado no construtor).

            //● Crie uma classe TesteProduto com o método Main, onde você deve ler os dados de um produto,
            //instanciar um produto e exibir na tela os campos do produto criado. Leia os dados de outro produto,
            //instancie outro produto e exiba na tela os campos do produto criado(utilize os dois construtores).

            //Depois altere os campos do produto criado anteriormente.Exiba novamente na tela os dados do produto.

            Etiqueta etiqueta1 = new Etiqueta("Marca B", "G");
            Produto produto1 = new Produto("Camiseta", 49.90, etiqueta1);
            Produto produto2 = new Produto("Calça", 99.90, "Marca A", "M");

            produto1.ExibirDetalhes();
            produto2.ExibirDetalhes();

            // Alterando os detalhes do primeiro produto
            Produto produto3 = new Produto("Camiseta Atualizada", 59.90, "Marca Nova", "P");
            produto3.ExibirDetalhes();

            Console.ReadLine();
        }
    }
}
