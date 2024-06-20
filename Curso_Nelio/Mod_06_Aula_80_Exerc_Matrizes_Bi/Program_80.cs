using System;

namespace Mod_06_Aula_80_Exerc_Matrizes_Bi
{
    class Program_80
    {
        static void Main(string[] args)
        {
            Console.Write("Informar a qtde de Linhas e Colunas da Matriz Bidimensional: ");
            int dimMatriz = int.Parse(Console.ReadLine());

            int[,] mbiMatriz = new int[dimMatriz, dimMatriz];

            // Ler / Armazenar valores das linhas
            for (int qtdLinhas = 0; qtdLinhas < dimMatriz; qtdLinhas++)
            {
                Console.WriteLine();
                Console.Write("Valores da linha #" + qtdLinhas + ": ");
                Console.WriteLine();

                // Ler / Armazenar valores das colunas
                for (int qtdColunas = 0; qtdColunas < dimMatriz; qtdColunas++)
                {
                    Console.Write("Informe os valores da posição #" + qtdColunas + ": ");
                    mbiMatriz[qtdLinhas, qtdColunas] = int.Parse(Console.ReadLine());
                }
                /*
                 * Solução do NÉLIO
                 *
                 * string[] values = Console.ReadLine().Split(' ');
                 * for (int qtdCols = 0; qtdCols < dimMatriz; qtdCols++)
                 * {
                 *   mbiMatriz[qtdLinhas, qtdCols] = int.Parse(values[qtdCols]);
                 * }
                */
            }

            // Demonstra todos os valores da matriz
            //for (int qtdLinhas = 0; qtdLinhas < dimMatriz; qtdLinhas++)
            //{
            //    Console.WriteLine();
            //    Console.Write("Valores da linha #" + qtdLinhas + ": ");
            //    Console.WriteLine();
            //    for (int qtdColunas = 0; qtdColunas < dimMatriz; qtdColunas++)
            //    {
            //        Console.WriteLine("Valores da posição #" + qtdColunas + ": " + mbiMatriz[qtdLinhas, qtdColunas].ToString());
            //    }
            //}

            int qtdNumNegativos = 0; 

            // Mostrar valores da diagonal principal
            for (int qtdLinhas = 0; qtdLinhas < dimMatriz; qtdLinhas++)
            {
                Console.WriteLine();
                Console.Write("Valores da linha #" + qtdLinhas + ": ");
                Console.WriteLine();
                for (int qtdColunas = 0; qtdColunas < dimMatriz; qtdColunas++)
                {
                    if (qtdColunas == qtdLinhas)
                        Console.WriteLine("Valores da posição #" + qtdColunas + ": " + mbiMatriz[qtdLinhas, qtdColunas].ToString());

                    if (mbiMatriz[qtdLinhas, qtdColunas] < 0)
                        qtdNumNegativos++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Quantidade de números negativos: " + qtdNumNegativos);
        }
    }
}
