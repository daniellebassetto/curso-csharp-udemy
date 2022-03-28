using System;
using System.Globalization;

namespace Saida {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
            /* Imprimir na saída padrão (console)
 
            Comandos:
            Console.WriteLine(valor);  --> coloca uma quebra de linha, ao contrário do que está abaixo
            Consele.Write(valor);
 
 
 
 
 
            */
            Console.Write("BOM DIA!");
            Console.WriteLine("BOM DIA!");  // Note que não ocorreu quebra de linha

            Console.WriteLine("Boa tarde!");
            Console.WriteLine("Boa TARDE!");

            char genero = 'F';
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";

            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo.ToString("F2"));  // limita o tanto de casas
            Console.WriteLine(saldo.ToString("F4"));
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));   // Imprime com o ponto
            Console.WriteLine(nome);

            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo);
            Console.WriteLine($"{nome} tem {idade} anos e saldo igual a {saldo:F2} reais");
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais ");
        }
    }
}
