using System;

namespace Operadores_logicos {
    class Program {
        static void Main(string[] args) {
            /* 
             OPERADOR           SIGNIFICADO
                &&                   E (verdadeiro apenas se todas forem verdadeiras)
                ||                   OU (verdadeiro se alguma for verdadeira)
                !                   NÃO (inverte)

            precedência: ! > && > ||
             */

            bool c1 = 2 > 3 && 4 != 5;  // False
            Console.WriteLine(c1);

            bool c2 = 2 > 3 || 4 != 5;  // True
            Console.WriteLine(c2);

            bool c3 = !(2 > 3) && 4 != 5;  // True
            Console.WriteLine(c3);

            Console.WriteLine("-------------------");

            bool c4 = 10 < 5;  // False
            Console.WriteLine(c4);

            bool c5 = c2 || c3 && c4;  // True
            Console.WriteLine(c5);
            


        }
    }
}
