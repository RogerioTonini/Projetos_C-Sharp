using System;
/*
 * Exercício proposto: 
 A dona de um pensionato possui dez quartos para alugar para estudantes, sendo esses quartos 
identificados pelos números 0 a 9.
 Quando um estudante deseja alugar um quarto, deve-se registrar o nome e email deste estudante.
 Fazer um programa que inicie com todos os dez quartos vazios, e depois leia uma quantidade N 
representando o número de estudantes que vão alugar quartos (N pode ser de 1 a 10). Em seguida, 
registre o aluguel dos N estudantes. Para cada registro de aluguel, informar o nome e email do
estudante, bem como qual dos quartos ele escolheu (de 0 a 9). Suponha que seja escolhido um 
quarto vago. Ao final, seu programa deve imprimir um relatório de todas ocupações do pensionato, 
por ordem de quarto, conforme exemplo.
 */

namespace Mod_06_Aula_70_Exec_Proposto
{
    class Program_70
    {
        static void Main(string[] args)
        {
            Clientes[] DadosClientes = new Clientes[10];

            Console.Write("Quantidade de quartos locados: ");
            int qtdQuartos = int.Parse(Console.ReadLine());

            /* Usuário digita as informações */
            for (int cont = 0; cont < qtdQuartos; cont++)
            {
                Console.WriteLine();
                Console.WriteLine("Aluguel #" + (cont + 1).ToString());
                Console.WriteLine();

                Console.Write("Informe o Numero do quarto : ");
                int numQuarto = int.Parse(Console.ReadLine());

                if (numQuarto != null)
                {
                    Console.WriteLine();
                    Console.Write("Locatário : ");
                    string nomeCliente = Console.ReadLine();

                    Console.Write("E-Mail : ");
                    string endMail = Console.ReadLine();

                    DadosClientes[cont] = new Clientes
                    {
                        NumQuarto = numQuarto,
                        NomeCliente = nomeCliente,
                        EndEmail = endMail
                    };
                }
            }
            Console.WriteLine();
            Console.WriteLine("Quartos Locados:");

            /* App mostra informações */
            for (int cont = 0; cont < qtdQuartos; cont++)
            {
                if (DadosClientes[cont] != null)
                {
                    Console.WriteLine();
                    Console.WriteLine(" Quarto #" + DadosClientes[cont].NumQuarto);
                    Console.WriteLine(" Cliente : " + DadosClientes[cont].NomeCliente);
                    Console.WriteLine(" E-Mail..: " + DadosClientes[cont].EndEmail);
                }
            }
        }
    }
}
