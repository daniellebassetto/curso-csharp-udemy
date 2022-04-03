using System;

namespace Escopo_e_inicializacao {
    class Program {
        static void Main(string[] args) {
            /*
            Escopo de uma variável: região do programa onde a variável é válida, ou seja, onde ela pode ser referenciada

            Uma variável não pode ser usada se não for iniciada
            
            Eu posso:
            - Declarar a variável para depois usá-la
            int x; 
            x = 10;

            - ou delacarar e ja usá-la
            int x = 10;
            */

            double preco = double.Parse(Console.ReadLine());
            double desconto = 0.0;  // Tenho que iniciá-la com 0 para evitar erros

            if (preco > 100.0) {
                desconto = preco * 0.1;  // O programa não consegue "identificar" variáveis declaradas dentro de blocos, por isso devemos declará-la no início
            }

            Console.WriteLine($"Desconto: {desconto}");
        }
    }
}
