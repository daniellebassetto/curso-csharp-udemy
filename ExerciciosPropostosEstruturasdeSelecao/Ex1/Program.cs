using System;

namespace Ex1 {
    class Program {
        static void Main(string[] args) {
            /*
            Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não. 
            */

            int num;
            Console.WriteLine("Insira um número inteiro: ");
            num = int.Parse(Console.ReadLine());

            if (num < 0) {
                Console.WriteLine("NÚMERO NEGATIVO!");
            }
            else {
                Console.WriteLine("NÚMERO POSITIVO!");
            }
        }
    }
}
