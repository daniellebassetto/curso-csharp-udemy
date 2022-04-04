using System;

namespace Ex6_for {
    class Program {
        static void Main(string[] args) {
            /*
             Ler um número inteiro N e calcular todos os seus divisores.
            */

            Console.WriteLine("Informe o número que deseja saber os divisores: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                if (n % i == 0) {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
