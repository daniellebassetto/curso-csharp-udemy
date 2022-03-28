using System;

namespace Conversao_implicita_e_casting {
    class Program {
        static void Main(string[] args) {

            float x = 4.5f;
            double y = x;  // Possivel pois o float tem 4 bits e o double tem 8
            Console.WriteLine(y);
          
            double a;
            float b;
            a = 5.1;
            b = (float)a;  // Aparece erro, pois double não 'cabe' em float! Assim, eu posso converter apenas por casting (uso o float na frente)
            Console.WriteLine(b);

           
            double c;
            int d;
            c = 5.1;
            d = (int)c;  // O mesmo ocorre com o int, pois o double tem valor quebrado, enquanto o int não tem. Os valores decimais serão excluidos.
            Console.WriteLine(d);

            int e = 5;
            int f = 2;
            double resultado = e / f; // Como e e f são int, o compilador entende que vc quer fazer uma divisão inteira, por isso só aparece a parte inteira.
            Console.WriteLine(resultado);
            double resultado2 = (double)e / f;  // Agora foi convertido e terá decimais
            Console.WriteLine(resultado2);
        }
    }
}
