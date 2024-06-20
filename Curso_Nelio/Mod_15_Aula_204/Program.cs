using System;

namespace Mod_15_Aula_204
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintService printService = new PrintService();

            Console.Write("How many values? ");
            int qtdvalores = int.Parse(Console.ReadLine());

            for(int cont = 0; cont < qtdvalores; cont++)
            {
                int valor = int.Parse(Console.ReadLine());
                printService.AddValue(valor);
            }

            printService.Print();

            Console.WriteLine("First: " + printService.First());
        }
    }
}
