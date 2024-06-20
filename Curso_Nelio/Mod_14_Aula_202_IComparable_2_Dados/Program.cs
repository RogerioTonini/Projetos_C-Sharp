using System;
using System.Collections.Generic;
using System.IO;
using Mod_14_Aula_202_IComparable_2_Dados.Entities;

namespace Mod_14_Aula_202_IComparable_2_Dados
{
    /*
    Faça um programa para ler um arquivo contendo funcionários (nome e salário) no
    formato .csv, armazenando-os em uma lista. 
    Depois, ordenar a lista por nome e mostrar o resultado na tela. 
    Nota: o caminho do arquivo pode ser informado "hardcode".
    */
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Users\rtoni\OneDrive\03-Cursos_Material\ArquivosTexto\ListaNomes_CSV.csv";
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    /*
                     * A lista que armazenará os dados será tipo Employee.
                     * Conforme a classe criada.
                     */
                    List<Employee> listaNomes = new List<Employee>();
                    /* 
                     * Le o arquivo texto e guarda o valor 
                     * dos elementos na -> listaNomes <-
                     */
                    while ( ! (sr.EndOfStream))
                    {
                        listaNomes.Add(new Employee(sr.ReadLine()));
                    }
                    /* Ordena a lista de Nomes e mostra na tela */
                    listaNomes.Sort();
                    foreach (Employee str in listaNomes)
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
