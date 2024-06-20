using System;

namespace Mod_15_Aula_205_Generics_T
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintService<string> printService = new PrintService<string>();

            Console.Write("How many values? ");
            int qtdvalores = int.Parse(Console.ReadLine());

            for (int cont = 0; cont < qtdvalores; cont++)
            {
                string valor = Console.ReadLine();
                printService.AddValue(valor);
            }

            printService.Print();

            Console.WriteLine("First: " + printService.First());
        }
    }
}
