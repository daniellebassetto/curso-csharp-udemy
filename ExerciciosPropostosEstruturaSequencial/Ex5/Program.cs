using System;
using System.Globalization;

namespace Ex5 {
    class Program {
        static void Main(string[] args) {
            /*Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1,
            o código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor
            a ser pago. */

            int peca1, num_p1, peca2, num_p2;
            double valor_p1, valor_p2, valorfinal1, valorfinal2, valor_pagar;

            Console.WriteLine("Código da peça 1: ");
            peca1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Números de peças 1: ");
            num_p1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor unitário da peça 1: ");
            valor_p1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            valorfinal1 = num_p1 * valor_p1;

            Console.WriteLine("Código da peça 2: ");
            peca2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Números de peças 2: ");
            num_p2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor unitário da peça 2: ");
            valor_p2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            valorfinal2 = num_p2 * valor_p2;
            valor_pagar = valorfinal1 + valorfinal2;

            Console.WriteLine($"Valor total peça {peca1}: R${valorfinal1.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Valor total peça {peca2}: R${valorfinal2.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Valor a ser pagp: R${valor_pagar.ToString("F2", CultureInfo.InvariantCulture)}");

           



        }
    }
}
