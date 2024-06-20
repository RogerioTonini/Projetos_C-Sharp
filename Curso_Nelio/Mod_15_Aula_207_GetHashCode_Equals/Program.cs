using System;
using Mod_15_Aula_207_GetHashCode_Equals.Entities;

namespace Mod_15_Aula_207_GetHashCode_Equals
{
    class Program
    {
        static void Main(string[] args)
        {
            //string a = "Maria";
            //string b = "Alex";

            /*
             * Utilizando a Classe Client
             */
            Client a = new Client { Name = "Maria", Email = "maria@gmail.com" };
            Client b = new Client { Name = "Alex", Email = "alex@gmail.com" };

            Console.WriteLine("O conteúdo da variável [a] é igual ao conteúdo da variável [b]: " + a.Equals(b));

            /*
            * O GetHashCode e o Equals comparam o contéudo da(s) variável(eis) em questão.
            * Já o "==" compara a referência de memória da variável. CUIDADO
            */
            Console.WriteLine(a == b);

            Console.WriteLine("O HashCode da variável [a] é: " + a.GetHashCode());
            Console.WriteLine("O HashCode da variável [b] é: " + b.GetHashCode());

        }
    }
}
