using System;
using System.Collections.Generic;
using System.Globalization;
using Mod_15_Aula_206_B_Generics_Restricoes.Services;


namespace Mod_15_Aula_206_B_Generics_Restricoes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> lista = new List<Product>();

            Console.Write("Entre com a quantidade de Produtos: ");
            int qtdNumeros = int.Parse(Console.ReadLine());

            for (int cont = 0; cont < qtdNumeros; cont++)
            {
                string[] arrDados = Console.ReadLine().Split(',');
                lista.Add(new Product(arrDados[0], double.Parse(arrDados[1], CultureInfo.InvariantCulture)));
            }
            CalculationService calculationService = new CalculationService();

            Product numeroMaximo = calculationService.Maximo(lista);

            Console.WriteLine("Produto de Maior valor: " + numeroMaximo);
        }
    }
}
