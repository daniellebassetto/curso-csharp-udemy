using System;
using System.Globalization;

namespace Ex6 {
    class Program {
        static void Main(string[] args) {
            /* Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, 
            calcule e mostre:
            a) a área do triângulo retângulo que tem A por base e C por altura.
            b) a área do círculo de raio C. (pi = 3.14159)
            c) a área do trapézio que tem A e B por bases e C por altura.
            d) a área do quadrado que tem lado B.
            e) a área do retângulo que tem lados A e B 
            */
            double A, B, C, triangulo, circulo, trapezio, quadrado, retangulo;

            Console.WriteLine("Informe o valor de A: ");
            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Informe o valor de B: ");
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Informe o valor de C: ");
            C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            triangulo = A * C / 2.0;
            circulo = 3.14159 * C * C;
            trapezio = (A + B) / 2.0 * C;
            quadrado = B * B;
            retangulo = A * B;

            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + circulo.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
