using System;
using System.Globalization;

namespace Ex2_while {
    class Program {
        static void Main(string[] args) {
            /*
            Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema
            cartesiano. Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo
            menos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma) 
            */
            double x, y;

            Console.WriteLine("Informe a coordenada X: ");
            x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Informe a coordenada Y: ");
            y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (x != 0 && y != 0) {
                if (x > 0 && y > 0) {
                    Console.WriteLine("Q1");
                }
                else if (x < 0 && y > 0) {
                    Console.WriteLine("Q2");
                }
                else if (x < 0 && y < 0) {
                    Console.WriteLine("Q3");
                }
                else {
                    Console.WriteLine("Q4");
                }

                Console.WriteLine("Informe a coordenada X: ");
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Informe a coordenada Y: ");
                y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
        }    
    }
}
