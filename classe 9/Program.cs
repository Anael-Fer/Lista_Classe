using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv9
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //09.Deseja - se escolher o transporte de mais barato para encomendas pequenas(volume inferior a 10 litros).
            //Os tipos de transporte são moto, bicicleta, patinete. Bicicleta e patinete têm restrição de distância máxima
            //5km.Moto tem acréscimo de taxa de seguro para o entregador, sendo valor fixo por viagem. Se usuário marcar
            //“urgência”, o preco_por_km dobra.Implemente em C# um programa completo para calcular frete em cada
            //tipo. O programa deverá iniciar com uma classe tipo Frete, sendo:


            //No programa principal, declare objetos segundo os tipos apresentados, conforme construtores.
            //Leia do teclado todos os dados pertinentes ao frete utilizando-os na função construtora quando necessário. Em
            //algum momento no programa principal as informações do frete são exibidas.O frete mais barato será escolhido
            //para contratação.

            Frete[] fretes = new Frete[3];
            fretes[0] = new Frete("Moto", 12, false, 5, 60);
            fretes[1] = new Frete("Bicicleta", 5, true, 2, 20);
            fretes[2] = new Frete("Patinete", 3, false, 1.5, 15);

            for (int i = 0; i < fretes.Length; i++)
            {
                fretes[i].CalcularFrete();
                fretes[i].ExibirFrete();
            }

            Frete maisBarato = fretes[0];

            for(int i = 0; i < fretes.Length; i++)
            {
                if (fretes[i].Preco_final < maisBarato.Preco_final)
                    maisBarato = fretes[i];
            }

            Console.WriteLine("Frete mais barato:");
            maisBarato.ExibirFrete();
            Console.ReadLine();
        }
    }
}
