using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv9
{
    internal class Frete
    {


        //• os atributos(private) tipo(string);
        //• os atributos(private) distancia(double), urgente(booleano), velocidade(double) e preco_por_km
        //(double) e preco_ f inal(double);
        //• os métodos(public): 01 construtor, 01 método exibe que mostra na saída padrão as informações atuais dos
        //atributos formatadas, 01 método que calcula o frete e tempo de entrega(em minutos) segundo as variáveis
        //pertinentes.

        private string tipo;
        private double distancia;
        private bool urgente;
        private double velocidade;
        private double preco_por_km;
        private double preco_final;

        public Frete(string tipo, double distancia, bool urgente, double velocidade, double preco_por_km)
        {
            this.tipo = tipo;
            this.distancia = distancia;
            this.urgente = urgente;
            this.velocidade = velocidade;
            this.preco_por_km = preco_por_km;
        }

        public void CalcularFrete()
        {
            double FatorUrgente = urgente ? 2 : 1;
            preco_final = distancia / preco_por_km * FatorUrgente;
        }

        public double TempoEntrega()
        {
            return distancia / velocidade * 60;
        }

        public void ExibirFrete()
        {
            Console.WriteLine($"Tipo: {tipo}, Distância: {distancia} km, Urgente: {urgente}, Preço Final: R$ {preco_final: F2}, " +
            $"Tempo de Entrega: {TempoEntrega():F1} minutos");
        }

        public double Preco_final
        {
            get { return preco_final; }
            set { preco_final = value; }
        }

    }
}
