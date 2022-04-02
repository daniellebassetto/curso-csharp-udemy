using System;
using System.Globalization;

namespace Entrada2 {
    class Program {
        static void Main(string[] args) {

            int n1 = int.Parse(Console.ReadLine());  // é necessário realizar essa conversão pois o ReadLine lê str
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine()); // Quando insiro um valor com ponto, não aparece! Com vírgula sim
            double n3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);  // Colocando ponto 

            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

            Console.WriteLine("Vôcê digitou: ");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2);
            Console.WriteLine(n3.ToString(CultureInfo.InvariantCulture)); // Imprimindo com ponto
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
