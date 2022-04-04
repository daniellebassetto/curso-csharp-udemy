using System;
using System.Globalization;

namespace Estruturas_de_repetição {
    class Program {
        static void Main(string[] args) {
            /*
            Estrutura "Enquanto"
            while (condição) {
                comando 1
                comando 2
            }

            regra:
            V: executa e volta
            F: pula fora
            */

            Console.WriteLine("Digite um número: ");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (x >= 0.0) {        
                double raiz = Math.Sqrt(x);
                Console.WriteLine($"Raiz = {raiz.ToString("F3", CultureInfo.InvariantCulture)}");

                Console.WriteLine("Digite um número: ");
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            
            Console.WriteLine("Número negativo!");

        }
    }
}
