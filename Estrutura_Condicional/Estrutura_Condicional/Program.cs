using System;

namespace Estrutura_Condicional {
    class Program {
        static void Main(string[] args) {
            /*
            if (se), else (senão) e else if (senão se)

             SIMPLES:
            if (condição) {
                 comando 1
                 comando 2
            }

             COMPOSTA:
            if (condição) {
                 comando 1
                 comando 2
            }
            else {
                 comando 3
                 comando 4
            }

             ENCADEAMENTOS:
            if (condição) {
                 comando 1
                 comando 2
            }
            else if (condição 2) {
                 comando 3
                 comando 4
            }
            else if (condição 3) {
                 comando 5
                 comando 6
            }
            else {
                 comando 7
                 comando 8
            }
            */

            Console.WriteLine("Entre com um número inteiro: ");
            int x = int.Parse(Console.ReadLine());

            if (x % 2 == 0) {
                Console.WriteLine("Número PAR!");
            }
            else {
                Console.WriteLine("Número ÍMPAR!");
            }

            Console.WriteLine("-----------------------------");

            Console.WriteLine("Qual a hora atual?");
            int hora = int.Parse(Console.ReadLine());

            if (hora < 12) {
                Console.WriteLine("BOM DIA!");
            }
            else if (hora < 18) {
                Console.WriteLine("BOA TARDE!");
            }
            else if (hora < 24) {
                Console.WriteLine("BOA NOITE!");
            }
            else {
                Console.WriteLine("Hora inválida!");
            }


        }
    }
}
