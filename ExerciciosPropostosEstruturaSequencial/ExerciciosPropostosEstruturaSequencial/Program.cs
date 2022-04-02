using System;

namespace ExerciciosPropostosEstruturaSequencial {
    class Program {
        static void Main(string[] args) {
            /* Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma 
            mensagem explicativa, conforme exemplos. */

            int A, B, soma;

            Console.WriteLine("Insira o primeiro valor: ");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o segundo valor: ");
            B = int.Parse(Console.ReadLine());

            soma = A + B;

            Console.WriteLine($"SOMA = {soma}");
            
        }
    }
}
