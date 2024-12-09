using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv11
{
    internal class Carro
    {

        //• Classe Carro:
        //o Propriedades: Marca, Modelo, Motor(um objeto da classe Motor).
        //o Método: ExibirDetalhes() exibe os dados do carro e as informações do motor.
        //• O construtor de Carro deve inicializar o motor recebendo um objeto da classe Motor.

        private string marca;
        private string modelo;
        Motor motor;

        public Carro(string marca, string modelo, Motor motor)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.motor = motor;
        }

        public void ExibirDetalhes()
        {
            motor.ExibirDetalhes();
            Console.WriteLine($"Marca: {marca} \n Modelo: {modelo}");
        }

    }
}
