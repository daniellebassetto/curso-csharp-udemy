using System;

namespace Funcoes {
    class Program {
        static void Main(string[] args) {
            /*
             Funções representam um processamento que possui um significado
               - Math.Sqrt(double)
               - Console.WriteLine(string)

            Podem receber dados de entraada e podem ou não retornar uma saída

            Em orientação a objetos, funções em classes recebem o nome de "métodos"
            */


            // Algotitmo para exibir o maior valor
            int n1, n2, n3;

            Console.WriteLine("Digite o primeiro número: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro número: ");
            n3 = int.Parse(Console.ReadLine());

            if (n1 > n2 && n1 > n3) {
                Console.WriteLine($"Maior = {n1}");
            }
            else if (n2 > n3) {
                Console.WriteLine($"Maior = {n2}");
            }
            else {
                Console.WriteLine($"Maior = {n3}");
            }

            // Algoritmo com função criada para exibir o maior valor
            double resultado = Maior(n1, n2, n3);

            Console.WriteLine("Maior = " + resultado);
        }

        static int Maior(int a, int b, int c) {
            int m;
            if (a > b && a > c) {
                m = a;
            }
            else if (b > c) {
                m = b;
            }
            else {
                m = c;
            }
            return m;
        }
    }
}
