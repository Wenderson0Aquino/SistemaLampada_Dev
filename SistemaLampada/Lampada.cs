using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLampada
{
    internal class Lampada
    {
        bool ligada;
        string voltagem;
        string potencia;
        Random random = new Random();

        public Lampada(string voltagem, string potencia)
        {
            ligada = false;
            this.voltagem = voltagem;
            this.potencia = potencia;
        }

        public string Ligar()
        {
            ligada = true;
            return "Lâmpada Ligada!";
        }

        public string Desligar()
        {
            ligada = false;
            return "Lâmpada Desligada!";
        }

        public string LerPotencia()
        {
            return potencia;
        }

        public string LerVoltagem()
        {
            return voltagem;
        }

        public void AlterarPotencia(string potencia)
        {
            this.potencia = potencia;
            Console.WriteLine(this.potencia);
        }

        public void AlterarVoltagem(string voltagem)
        {
            this.voltagem = voltagem;
            Console.WriteLine(this.voltagem);
        }

        public void QueimarLampada()
        {
            if (ligada && random.NextDouble() == 0.15)
            {
                Console.WriteLine("A Lâmpada Queimou!");
            }
        }
    }
}
