using System;

namespace Operadores_aritmeticos {
    class Program {
        static void Main(string[] args) {
            /*
                    OPERADOR        SIGNIFICADO
                        +             adição
                        -           subtração
                        *           multiplicação
                        /            divisão
                        %         resto da divisão

            * % / tem precedência maior que + -
            */

            int n1 = 3 + 4 * 2;
            Console.WriteLine(n1);

            int n2 = (3 + 4) * 2;
            Console.WriteLine(n2);

            int n3 = 17 % 3;
            Console.WriteLine(n3);

            int n4 = 10 / 8;
            Console.WriteLine(n4);

            float n5 = 10 / 8f;
            Console.WriteLine(n5);

            double n6 = (double) 10 / 8;
            Console.WriteLine(n6);
            
            // OU
            
            double n7 = 10.0 / 8;  // Nesse exemplo, pelo menos um dos dois deve ter o '.0' para indicar que é double
            Console.WriteLine(n7);

            // exemplo de baskara

            double a = 1.0, b = -3.0, c = -4.0;
            double delta = Math.Pow(b, 2.0) - 4 * a * c;
            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);
            Console.WriteLine(delta);
            Console.WriteLine(x1);
            Console.WriteLine(x2);
        }
    }
}
