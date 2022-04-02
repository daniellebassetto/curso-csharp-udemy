using System;

namespace Ex3 {
    class Program {
        static void Main(string[] args) {
            /* 
            Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença 
            do produtode A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D)
            */

            int A, B, C, D, Diferenca;

            Console.WriteLine("Informe o valor de A: ");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor de B: ");
            B = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor de C: ");
            C = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor de D: ");
            D = int.Parse(Console.ReadLine());

            Diferenca = (A * B - C * D);
            Console.WriteLine($"DIFERENÇA: {Diferenca}");
        }
    }
}
