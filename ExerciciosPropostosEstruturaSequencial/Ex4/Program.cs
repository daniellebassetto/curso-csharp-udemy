using System;
using System.Globalization;

namespace Ex4 {
    class Program {
        static void Main(string[] args) {
            /* Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe 
             por hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com 
            duas casas decimais. */

            int num, horas;
            double valorhoras, salario;

            Console.WriteLine("Insira o número do funcionário: ");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o número de horas trabalhadas: ");
            horas = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor que o funcionário recebe por hora: ");
            valorhoras = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = horas * valorhoras;

            Console.WriteLine($"Número do funcionário: {num}");
            Console.WriteLine($"Salário: R${salario.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
