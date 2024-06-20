using System;
using System.Globalization;
using System.Collections.Generic;

/*
 *   Fazer um programa para ler 2 números inteiros M e N, e depois ler uma matriz
 * de M linhas por N linhas contendo números inteiros, podendo haver repetições.
 * Em seguida, ler um número inteiro X que pertence à Matriz. Para cada ocorrência 
 * de X, mostrar os valores à Esquerda, Direita, Acima e abaixo de X (quando houver).
 */


namespace Mod_06_Aula_81_Exerc_Matrizes_Bi
{
    class Program_81
    {
        static void Main(string[] args)
        {
            Console.Write("Informar a qtde de Linhas da Matriz: ");
            int qtdTotLinhas = int.Parse(Console.ReadLine());
            Console.Write("Informar a qtde de Colunas da Matriz: ");
            int qtdTotColunas = int.Parse(Console.ReadLine());

            int[,] mbiMatriz = new int[qtdTotLinhas, qtdTotColunas];

            // Ler / Armazenar valores das linhas
            for (int qtdLinhas = 0; qtdLinhas < qtdTotLinhas; qtdLinhas++)
            {
                Console.WriteLine();
                Console.Write("Valores da linha #" + qtdLinhas + ": ");
                Console.WriteLine();

                // Ler / Armazenar valores das colunas
                for (int qtdColunas = 0; qtdColunas < qtdTotColunas; qtdColunas++)
                {
                    Console.Write("Informe os valores da posição #" + qtdColunas + ": ");
                    mbiMatriz[qtdLinhas, qtdColunas] = int.Parse(Console.ReadLine());
                }
            }

            //Demonstra todos os valores da matriz
            for (int qtdLinhas = 0; qtdLinhas < qtdTotLinhas; qtdLinhas++)
            {
                Console.WriteLine();
                Console.Write("Valores da linha #" + qtdLinhas + ": ");

                string valores = "";
                for (int qtdColunas = 0; qtdColunas < qtdTotColunas; qtdColunas++)
                {
                    valores += mbiMatriz[qtdLinhas, qtdColunas].ToString() + ' ';
                }
                Console.WriteLine(valores);
            }

            // Solicita e Verifica a existência de um número digitado.
            Console.WriteLine();
            Console.Write("Informar um número digitado: ");
            int numDigitado = int.Parse(Console.ReadLine());

            if (PesquisaNumero(mbiMatriz, numDigitado, qtdTotLinhas, qtdTotColunas) != true) ;
            //bool encontrou = false;

            //for (int qtdLinhas = 0; qtdLinhas < qtdTotLinhas; qtdLinhas++)
            //{
            //    for (int qtdColunas = 0; qtdColunas < qtdTotColunas; qtdColunas++)
            //    {
            //        if (mbiMatriz[qtdLinhas, qtdColunas] == numDigitado)
            //            encontrou = true;
            //    }
            //}

            //if (! encontrou)
            //{
            //    Console.WriteLine("O número: " + numDigitado.ToString() + " NÃO foi encontrado!");
                return;
            //}

            for (int qtdLinhas = 0; qtdLinhas < qtdTotLinhas; qtdLinhas++)
            {
                Console.WriteLine();
                for (int qtdColunas = 0; qtdColunas < qtdTotColunas; qtdColunas++)
                {
                    if (mbiMatriz[qtdLinhas, qtdColunas] == numDigitado)
                    {
                        if (qtdLinhas != 0)
                            Console.WriteLine("Vizinho linha Acima: " + mbiMatriz[qtdLinhas - 1, qtdColunas]);

                        if (qtdLinhas + 1 < qtdTotLinhas)
                            Console.WriteLine("Vizinho linha Abaixo: " + mbiMatriz[qtdLinhas + 1, qtdColunas]);

                        if (qtdColunas != 0)
                            Console.WriteLine("Vizinho da Esquerda: " + mbiMatriz[qtdLinhas, qtdColunas - 1]);

                        if (qtdColunas + 1 < qtdTotColunas)
                            Console.WriteLine("Vizinho da Direita: " + mbiMatriz[qtdLinhas, qtdColunas + 1]);
                    }
                }
            }
        }

        static bool PesquisaNumero(int[,] mbiMatriz, int numDigitado, int qtdTotLinhas, int qtdTotColunas)
        {
            for (int qtdLinhas = 0; qtdLinhas < qtdTotLinhas; qtdLinhas++)
            {
                for (int qtdColunas = 0; qtdColunas < qtdTotColunas; qtdColunas++)
                {
                    if (mbiMatriz[qtdLinhas, qtdColunas] == numDigitado)
                        return true;
                }
            }
            Console.WriteLine();
            Console.WriteLine("O número: " + numDigitado.ToString() + " NÃO foi encontrado!");
            return false;
        }
    }
}
