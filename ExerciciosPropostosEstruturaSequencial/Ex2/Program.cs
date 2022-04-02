using System;
using System.Globalization;

namespace Ex2 {
    class Program {
        static void Main(string[] args) {
            /* 
            Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo 
            com quatro casas decimais conforme exemplos.
           
            Fórmula da área: area = π . raio2
            Considere o valor de π = 3.14159
            */

            double R, A, pi = 3.14159;

            Console.WriteLine("Infome o raio do círculo: ");
            R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            A = pi * R * R;
            Console.WriteLine($"Área do círculo: {A.ToString("F4", CultureInfo.InvariantCulture)}");
        }
    }
}
