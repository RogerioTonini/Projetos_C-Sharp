using System;
using System.Collections.Generic;
using System.IO;

namespace Mod_14_Aula_202_IComparable_1_Dado
/*
Faça um programa para ler um arquivo contendo nomes de pessoas(um nome por
linha), armazenando-os em uma lista.
Depois, ordenar os dados dessa lista e mostrá-los ordenadamente na tela. 
Nota: o caminho do arquivo pode ser informado "hardcode".
*/
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Users\rtoni\OneDrive\03-Cursos_Material\ArquivosTexto\ListaNomes.txt";
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<string> listaNomes = new List<string>();
                    /* 
                     * Le o arquivo texto e guarda o valor 
                     * dos elementos na -> listaNomes <-
                     */
                    while (! (sr.EndOfStream))
                    {
                        listaNomes.Add(sr.ReadLine());
                    }
                    /* Ordena a lista de Nomes e mostra na tela */
                    listaNomes.Sort();
                    foreach (string str in listaNomes)
                    {
                        Console.WriteLine(str);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
