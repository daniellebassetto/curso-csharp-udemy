using System;
using System.Globalization;

namespace Ex5 {
    class Program {
        static void Main(string[] args) {
            /*
            Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A
            seguir, calcule e mostre o valor da conta a pagar 

            CÓDIGO          ESPECIFICAÇÃO       PRODUTO
              1             Cachorro Quente      4.00
              2             X - Salada           4.50
              3             X - Bacon            5.00
              4             Torrada simples      2.00   
              5             Refrigerante         1.50
            */

            int cod, quant;
            double total;

            Console.WriteLine("Insira o código do produto: ");
            cod = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira a quantidade comprada desse produto: ");
            quant = int.Parse(Console.ReadLine());

            if (cod == 1) {
                total = 4.00 * quant;
                Console.WriteLine($"Total: R${total.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            else if (cod == 2) {
                total = 4.50 * quant;
                Console.WriteLine($"Total: R${total.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            else if (cod == 3) {
                total = 5.00 * quant;
                Console.WriteLine($"Total: R${total.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            else if (cod == 4) {
                total = 2.00 * quant;
                Console.WriteLine($"Total: R${total.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            else if (cod == 5) {
                total = 1.50 * quant;
                Console.WriteLine($"Total: R${total.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            else {
                Console.WriteLine("Código inválido!");
            }
        }
    }
}
