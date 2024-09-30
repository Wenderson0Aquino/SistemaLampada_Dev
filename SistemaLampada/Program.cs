using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLampada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lampada lampada = new Lampada("127", "60");

            Console.WriteLine(lampada.Ligar());
            lampada.AlterarPotencia("220");
            lampada.AlterarVoltagem("90");
            lampada.QueimarLampada();

            Console.ReadKey();
        }
    }
}
