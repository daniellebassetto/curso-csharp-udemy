using System;

namespace Entrada {
    class Program {
        static void Main(string[] args) {
            /*
            Comando: Console.ReadLine()
                Lê a entrada paadrão até a quebra de linha
                Retorna os dados na forma de string
            */

            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            string s = Console.ReadLine();
            string[] v = s.Split(' ');  // Recorta a variável s com base no espaço em branco
            // Ou apago 'string s' e apenas coloco string[] = Console.ReadLine().Split(' ');
            string a = v[0];  // Guardando o primeiro recorte em a
            string b = v[1];  // Guardando o segundo recorte em b
            string c = v[2];  // Guardando o terceiro recorte em c


            Console.WriteLine($"Você digitou: {frase}");
            Console.WriteLine($"Você digitou: {x}");
            Console.WriteLine($"Você digitou: {y}");
            Console.WriteLine($"Você digitou: {z}");
            Console.WriteLine($"Você digitou: {a}");
            Console.WriteLine($"Você digitou: {b}");
            Console.WriteLine($"Você digitou: {c}");
            


             
        }
    }
}
