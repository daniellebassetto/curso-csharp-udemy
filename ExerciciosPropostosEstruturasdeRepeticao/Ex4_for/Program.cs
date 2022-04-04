using System;
using System.Globalization;

namespace Ex4_for {
    class Program {
        static void Main(string[] args) {
            /*
            Fazer um programa para ler um número N. Depois leia N pares de números e mostre a divisão do primeiro pelo
            segundo. Se o denominador for igual a zero, mostrar a mensagem "divisao impossivel". 
            */

            Console.WriteLine("Informe o número de vezes que deseja executar: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {

                Console.WriteLine("Informe o primeiro número: ");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe o segundo número: ");
                int y = int.Parse(Console.ReadLine());

                if (y == 0) {
                    Console.WriteLine("Divisao impossivel");
                }
                else {
                    double div = (double)x / y;
                    Console.WriteLine($"Divisão = {div.ToString("F1", CultureInfo.InvariantCulture)}");
                }
            }
        }
    }
}
