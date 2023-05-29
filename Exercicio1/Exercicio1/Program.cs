using System;
using System.Globalization;
namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            // No início do programa, declaramos variáveis:

            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preço1 = 2100.0;
            double preço2 = 650.50;
            double medida = 53.234567;

            /*
             Em seguida, usando os valores das variáveis, produza a seguinte saída:
 
            Produtos:
            Computador, cujo preço é $ 2100,00.
            Mesa de escritório, cujo preço é $ 650,50.

            Registro: 30 anos de idade, código 5290 e gênero: M.

            Medida com oito casas decimais: 53,23456700
            Arredondado (três casas decimais): 53,235
            Separador decimal "invariant culture": 53.235
            */

            // Código para as saídas solicitadas acima. 

            Console.WriteLine("Produtos: ");
            Console.WriteLine($"{produto1}, cujo preço é ${preço1:F2}.");
            Console.WriteLine($"{produto2}, cujo preço é ${preço2:F2}.");
            Console.WriteLine();

            Console.WriteLine("Registro: {0} anos de idade, código {1} e gênero: {2}.", idade, codigo, genero);
            Console.WriteLine();

            Console.WriteLine("Medida com oito casas decimais: {0:F8}.", medida);
            Console.WriteLine("Arredondando para três casas decimais: {0:F3}.", medida);
            Console.WriteLine("utilizando separador decimal Invariant Culture: " + 
                medida.ToString("F3", CultureInfo.InvariantCulture)); 
            
        }
    }
}
