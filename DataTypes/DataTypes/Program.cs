using System;

namespace DataTypes {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
            // C# built-in data types

            byte n1 = 126;
            int n2 = 1000;
            sbyte n3 = 127;  //O sbyte vai de -128 a 127, assim, quando ele passa de 127, ele volta para -128
            int n4 = 2147483647;
            long n5 = 2147483648L;  // Mais longo que o int
            bool completo = false;  // True ou false
            char genero = 'F';  // Guarda um caracter unicode
            char letra = '\u0041';  // Posso colocar diretamente um código unicode (entrar no site)
            float n6 = 4.5f;  // número com ponto flutuante, é necessário por f na frente para que o programa não considere double
            double n7 = 4.5;
            string nome = "Maria";  // Note que em string usa-se aspas duplas, ao contrário de char, além de ser imutável
            object obj1 = "Alex";  // toda classe em C# é subclasse de object
            object obj2 = 4.5f;

            Console.WriteLine(int.MinValue);  // Min.Value mostra o valor mínimo da função e Max.Value mostra o valor máximo
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(sbyte.MinValue);
            Console.WriteLine(sbyte.MaxValue);
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(long.MinValue);
            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(decimal.MinValue);




            n3++;


            Console.WriteLine(completo);
            Console.WriteLine(n6);
            Console.WriteLine(n7);
            Console.WriteLine(letra);
            Console.WriteLine(genero);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);

            /*
            Restrições para nomes de variáveis 
            - Não pode comçar com dígito: use uma letra ou _
            - Não acentuar ou usar til
            - Não pode ter espaço
            exs: int _5minutos;
                 int salario;
                 int salarioDoFuncionario;

            Convenções
            - Camel Case: lastName (parâmetros de métodos, variáveis dentro de métodos)
            - Pascal Case: LastName (namespaces, classe, properties e métodos)
            - Padrão _lastName (atributos "internos" da classe)
           */
        }
    }
}
