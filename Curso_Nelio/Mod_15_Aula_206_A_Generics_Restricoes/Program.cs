using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mod_15_Aula_206_A_Generics_Restricoes.Services;

namespace Mod_15_Aula_206_A_Generics_Restricoes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>();

            Console.Write("Entre com a quantidade de números: ");
            int qtdNumeros = int.Parse(Console.ReadLine());

            for (int cont = 0; cont < qtdNumeros; cont++)
            {
                int vlrNumero = int.Parse(Console.ReadLine());
                lista.Add(vlrNumero);
            }

            CalculationService calculationService = new CalculationService();

            int numeroMaximo = calculationService.Maximo(lista);

            Console.WriteLine("Maior Número digitado: " + numeroMaximo);
        }
    }
}
