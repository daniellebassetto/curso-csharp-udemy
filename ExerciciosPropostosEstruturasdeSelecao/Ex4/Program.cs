using System;

namespace Ex4 {
    class Program {
        static void Main(string[] args) {
            /*
             Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o 
            mesmo pode começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas
             */

            int hinicial, hfinal, duracao;

            Console.WriteLine("Insira a hora inicial do jogo: ");
            hinicial = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira a hora final do jogo: ");
            hfinal = int.Parse(Console.ReadLine());

            if (hinicial >= 1  && hfinal <= 24) {
                duracao = hfinal - hinicial;
                Console.WriteLine($"Duração do jogo: {duracao} hora(s)");
            }
            else {
                Console.WriteLine("Hora inicial ou final inválida!");
            }
        }
    }
}
