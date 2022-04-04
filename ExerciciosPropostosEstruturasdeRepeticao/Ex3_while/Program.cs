using System;

namespace Ex3_while {
    class Program {
        static void Main(string[] args) {
            /*
            Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva
            um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel
            4.Fim). Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até
            que seja válido). O programa será encerrado quando o código informado for o número 4. Deve ser escrito a
            mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível
            */

            int comb, clientes_alcool, clientes_gasolina, clientes_diesel;

            clientes_alcool = 0;
            clientes_gasolina = 0;
            clientes_diesel = 0;


            Console.WriteLine("Informe o combustível abastecido [1.Álcool 2. Gasolina 3.Diesel 4.Encerra]: ");
            comb = int.Parse(Console.ReadLine());

            while (comb != 4) {
                if (comb < 1 || comb > 4) {
                    Console.WriteLine("Código inválido");
                    Console.WriteLine("Informe o combustível abastecido [1.Álcool 2. Gasolina 3.Diesel 4.Encerra]: ");
                    comb = int.Parse(Console.ReadLine());
                }
                else if (comb == 1) {
                    Console.WriteLine("MUITO OBRIGADO!");
                    clientes_alcool += 1;
                    Console.WriteLine("Informe o combustível abastecido [1.Álcool 2. Gasolina 3.Diesel 4.Encerra]: ");
                    comb = int.Parse(Console.ReadLine());
                }
                else if (comb == 2) {
                    Console.WriteLine("MUITO OBRIGADO!");
                    clientes_gasolina += 1;
                    Console.WriteLine("Informe o combustível abastecido [1.Álcool 2. Gasolina 3.Diesel 4.Encerra]: ");
                    comb = int.Parse(Console.ReadLine());
                }
                else {
                    Console.WriteLine("MUITO OBRIGADO");
                    clientes_diesel += 1;
                    Console.WriteLine("Informe o combustível abastecido [1.Álcool 2. Gasolina 3.Diesel 4.Encerra]: ");
                    comb = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine($"PROGRAMA ENCERRADO");
            Console.WriteLine($"Álcool = {clientes_alcool} clientes");
            Console.WriteLine($"Gasolina = {clientes_gasolina} clientes");
            Console.WriteLine($"Diesel = {clientes_diesel} clientes");
        }
    }
}
