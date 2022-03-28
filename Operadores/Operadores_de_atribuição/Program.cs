using System;

namespace Operadores_de_atribuição {
    class Program {
        static void Main(string[] args) {
            /*
            OPERADOR        EXEMPLO     SIGNIFICADO
                =            a = 10     a recebe 10
               +=           a += 2      a recebe a + 2
               -+           a -= 2      a recebe a - 2
               *=           a *= 2      a recebe a * 2
               /=           a /= 2      a recebe a / 2
               %=           a %= 3      a recebe a % 3
               ++         a++ ou ++a    a = a + 1
               --         a-- ou --a    a = a - 1
            */

            int a = 10;

            Console.WriteLine(a);

            a += 2;
            Console.WriteLine(a);

            a -= 2;
            Console.WriteLine(a);

            a *= 2;
            Console.WriteLine(a);

            a /= 2;
            Console.WriteLine(a);

            a %= 3;
            Console.WriteLine(a);

            string s = "ABC";
            Console.WriteLine(s);

            s += "DEF";
            Console.WriteLine(s);

            int b = 10;
            Console.WriteLine(b);

            b++;
            Console.WriteLine(b);

            b--;
            Console.WriteLine(b);

            int c = 10;
            int d = ++c;
            Console.WriteLine(c);
            Console.WriteLine(d);  // Note que ambas ficaram 11, se eu colocasse c++, ele atribuiria apenas a c e a d continuaria 10
        }
    }
}
