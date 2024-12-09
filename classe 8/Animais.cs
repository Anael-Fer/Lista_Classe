using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv8
{
    internal class Animais
    {


        //08.Uma clínica veterinária deseja automatizar seu processo de cadastro de animais. Sabe - se que os animais
        //são documentados por nome, tipo, peso e se possui deficiência.Desenvolva um programa em C# com a
        //classe Animais para realizar tal cadastro, contendo:
        //a) variáveis privadas nome(string), nomeDono(string), tipo(string), peso(f loat) e def(bool);
        //b) construtor e destrutor;
        //c) “getters” e “setters”;
        //d) programa principal.

        private string nome;
        private string nomeDono;
        private string tipo;
        private float peso;
        private bool def;

        public Animais(string nome, string nomeDono, string tipo, float peso, bool def)
        {
            this.nome = nome;
            this.nomeDono = nomeDono;
            this.tipo = tipo;
            this.peso = peso;
            this.def = def;
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string NomeDono
        {
            get { return nomeDono; }
            set { nomeDono = value; }
        }

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }


        public float Peso
        {
            get { return peso; }
            set { peso = value; }
        }

        public bool Def
        {
            get { return def; }
            set { def = value; }
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {nome}, Tipo: {tipo}, Peso: {peso} kg, Dono: {nomeDono}, Deficiência: {(def ? "Sim" : "Não")}");
        }
    }

}
