using System;
using System.Globalization;
using System.Collections.Generic;

/*
 *  Fazer um programa para ler um número inteiro N e depois os dados (ID, NOME, SALARIO) de N Funcionários.
 * Não deve haver repetição de ID.
 *  Em seguinda, efetuar o aumento de X por cento no salário de salário de um determinado funcionário. Para
 * isso, o progrma deve ler um ID e o valor X. Se ID informado não existir, mostrar uma mensagem e abortar a 
 * operação. Ao final, mostrar a listagem atualizada dos funcionários, conforme exemplos.
 *  Lembre-se de aplicar a técnica de encapsulamento para não permitir que o salário possa ser mudado 
 * livremente. Um salário só pode ser aumentado com base em uma operação de aumento por pocentagem dada.
 */

namespace Mod_06_Aula_78_Exerc_Proposto
{
    class Program_78
    {
        static void Main(string[] args)
        {
            List<Colaborador> lColaborador = new List<Colaborador>();

            Console.Write("How many employees will be registered: ");
            int qtdEmployee = int.Parse(Console.ReadLine());

            for (int cont = 1; cont <= qtdEmployee; cont++)
            {
                Console.WriteLine();
                Console.WriteLine("Employee #" + (cont).ToString());

                Console.Write("Id....: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Name..: ");
                string nome_colab = Console.ReadLine();

                Console.Write("Salary: ");
                double vlr_salar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                lColaborador.Add(new Colaborador(id, nome_colab, vlr_salar));
            }
            Console.WriteLine();
            Console.Write("Enter the employee ID that will have Salary increase: ");
            int searchId = int.Parse(Console.ReadLine());

            Colaborador emp = lColaborador.Find(x => x.ID == searchId);

            if (emp != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.AumentoSalario(percentage);
            }
            else
            {
                Console.WriteLine("This ID does not exist!");
            }
            Console.WriteLine();
            Console.WriteLine("Update list of Employees:");
            foreach (Colaborador obj in lColaborador)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
