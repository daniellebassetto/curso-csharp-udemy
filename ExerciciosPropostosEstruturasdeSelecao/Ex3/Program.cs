using System;

namespace Ex3 {
    class Program {
        static void Main(string[] args) {
            /*
            Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao
            Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser
            digitados em ordem crescente ou decrescente
            */

            int A, B;

            Console.WriteLine("Insira o valor de A: ");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor de B: ");
            B = int.Parse(Console.ReadLine());

            if (A % B == 0 || B % A == 0) {
                Console.WriteLine("São múltiplos!");
            }
            else {
                Console.WriteLine("Não são múltiplos!");
            }

        }
    }
}
