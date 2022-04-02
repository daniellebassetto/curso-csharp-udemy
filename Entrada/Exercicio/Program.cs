using System;
using System.Globalization;

namespace Exercicio {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Entre com seu nome completo: ");
            string nome = Console.ReadLine();
            
            

            Console.WriteLine("Quantos quartos tem na sua casa? ");
            int quartos = int.Parse(Console.ReadLine());
            
            

            Console.WriteLine("Entre com o preço de um produto: ");
            double preco = double.Parse(Console.ReadLine());
            
            

            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha): ");
            string[] v = Console.ReadLine().Split(' '); 
            string nome1 = v[0]; 
            int idade  = int.Parse(v[1]);  
            double altura = double.Parse(v[2], CultureInfo.InvariantCulture);
           


            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco);
            Console.WriteLine(nome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));



            /*
             Console.WriteLine("Entre com seu nome completo:");
             string fullName = Console.ReadLine();
             Console.WriteLine("Quantos quartos tem na sua casa?");
             int bedrooms = int.Parse(Console.ReadLine());
             Console.WriteLine("Enter product price:");
             double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             Console.WriteLine("Entre seu último nome, idade e altura (mesma linha):");
             string[] vect = Console.ReadLine().Split(' ');
             string lastName = vect[0];
             int age = int.Parse(vect[1]);
             double height = double.Parse(vect[2], CultureInfo.InvariantCulture);
             Console.WriteLine(fullName);
             Console.WriteLine(bedrooms);
             Console.WriteLine(price.ToString("F2", CultureInfo.InvariantCulture));
             Console.WriteLine(lastName);
             Console.WriteLine(age);
             Console.WriteLine(height.ToString("F2", CultureInfo.InvariantCulture));
            */
        }
    }
}
