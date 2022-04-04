using System;

namespace Estrutura_for {
    class Program {
        static void Main(string[] args) {
            /*
            for (inicio; condição; incremento) {
                comando 1
                comando 2
            }
             
            inicio = executa somente a primeira vez
            condição = V = executa e volta
                       F = pula fora

            incremento = executa toda vez depois de voltar  
            */

            Console.WriteLine("Quantos números inteiros você vai digitar? ");
            int n = int.Parse(Console.ReadLine());

            int soma = 0;

            for (int i = 1; i <= n; i++) {
                Console.WriteLine($"Valor {i}: ");
                int valor = int.Parse(Console.ReadLine());
                soma += valor;
            }
            Console.WriteLine($"Soma = {soma}");


        }
    }
}
