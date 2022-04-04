using System;
using System.Globalization;

namespace Ex3_for {
    class Program {
        static void Main(string[] args) {
            /*
            Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada caso de teste consiste
            de 3 valores reais, cada um deles com uma casa decimal. Apresente a média ponderada para cada um destes
            conjuntos de 3 valores, sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem
            peso 5.
            */

            Console.WriteLine("Número de testes que deseja realizar: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                Console.WriteLine("Insira o primeiro valor: ");
                double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Insira o segundo valor: ");
                double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Insira o terceiro valor: ");
                double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                double media = (a * 2.0 + b * 3.0 + c * 5.0) / 10.0;

                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
