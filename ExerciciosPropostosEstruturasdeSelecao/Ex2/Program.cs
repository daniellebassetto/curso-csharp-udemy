using System;

namespace Ex2 {
    class Program {
        static void Main(string[] args) {
            /*
             Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.
            */

            int num;

            Console.WriteLine("Insira um número inteiro: ");
            num = int.Parse(Console.ReadLine());

            if (num % 2 == 0) {
                Console.WriteLine("Número par!");
            }
            else {
                Console.WriteLine("Número ímpar!");
            }
        }
    }
}
