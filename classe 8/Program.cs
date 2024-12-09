using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //08.Uma clínica veterinária deseja automatizar seu processo de cadastro de animais. Sabe - se que os animais
            //são documentados por nome, tipo, peso e se possui deficiência.Desenvolva um programa em C# com a
            //classe Animais para realizar tal cadastro, contendo:
            //a) variáveis privadas nome(string), nomeDono(string), tipo(string), peso(f loat) e def(bool);
            //b) construtor e destrutor;
            //c) “getters” e “setters”;
            //d) programa principal.

            Animais[] animal = new Animais[10];

            string nome, nomeDono, tipo;
            float peso;
            bool def;
            int cont = 0;

            Console.WriteLine("Cadastro de animais: ");
            while(true)
            {
                Console.WriteLine("Digite o nome do animal (ou digite 'sair' para o fim do programa): ");
                nome = Console.ReadLine().ToLower();
                if (nome == "sair")
                    break;

                Console.WriteLine("Digite o nome do dono: ");
                nomeDono = Console.ReadLine().ToLower();

                Console.WriteLine("Digite o tipo do animal: ");
                tipo = Console.ReadLine().ToLower();

                Console.WriteLine("Digite o peso do animal: ");
                peso = float.Parse(Console.ReadLine());

                Console.WriteLine("Ele possui deficiência? (digite true ou false): ");
                def = bool.Parse(Console.ReadLine());

                animal[cont++] = new Animais(nome, nomeDono, tipo, peso, def);
            }

            Console.WriteLine("\nAnimais cadastrados!");

            for (int i = 0; i < cont; i++)
            {
                animal[i].ExibirDados();
            }

        }
    }
}
