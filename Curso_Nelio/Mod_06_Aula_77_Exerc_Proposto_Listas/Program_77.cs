using System;
using System.Collections.Generic;

namespace Mod_06_Aula_77_Exerc_Proposto_Listas
{
    class Program_77
    {
        static void Main(string[] args)
        {
            List<string> lista = new List<string>();

            lista.Add("Maria");
            lista.Add("Alex");
            lista.Add("Bob");
            lista.Add("Anna");

            // Comando adiciona em determinada posição um valor a Lista
            lista.Insert(2, "Marco");

            ListaConteudo(lista, "(Completo)");
            Console.WriteLine(" ");
            Console.WriteLine("Qtde total de itens: " + lista.Count);
            PulaLinha();

            // Encontrar a primeira ocorrencia da letra A
            string teste = lista.Find(Pesquisa);

            /* Utilizando a função LAMBDA
             * Função genérica para ser utilizada para otimizar o código
             * Não há a necessidade da criação da função PESQUISA
             */
            string s1 = lista.Find(x => x[0] == 'A');
            string s2 = lista.FindLast(x => x[0] == 'A');

            Console.WriteLine("Primeira ocorrência da letra [A] na lista: " + s1);
            Console.WriteLine("Última   ocorrência da letra [A] na lista: " + s2);
            PulaLinha();

            int pos1 = lista.FindIndex(x => x[0] == 'M');
            int pos2 = lista.FindLastIndex(x => x[0] == 'M');

            Console.WriteLine("Primeira posição da letra [M] na lista: " + pos1);
            Console.WriteLine("Última   posição da letra [M] na lista: " + pos2);
            PulaLinha();

            // Filtra o conteudo da lista de acôrdo com solicitação
            List<string> lista_result = lista.FindAll(x => x.Length == 5);
            ListaConteudo(lista_result, "(Atualizado)");
            PulaLinha();

            /* O método .Remove removerá apenas o que for solicitado. 
             * Caso a solicitação não exista, o progrma continuará rodando
             * sem gerar erros e a Lista NÃO soferá nenhuma alteração.
             */

            // Remove da lista o Nome solicitado
            //lista.Remove("Alex");

            // Remove todos os Nomes iniciados pela letra [B]
            //lista.RemoveAll(x => x[0] == 'B');

            // Remove a posição num. 2 da Lista
            //lista.RemoveAt(2);

            // Remove a partir da Primeira posição, 2 posições.
            lista.RemoveRange(1, 2);
            ListaConteudo(lista, "(Atualizado)");

        }
        static void ListaConteudo(List<string> lcLista, string tpLista)
        {
            Console.WriteLine("Relação de nomes: " + tpLista);
            Console.WriteLine("-----------------");
            foreach (string obj in lcLista)
            {
                Console.WriteLine(obj);
            }
        }
        static void PulaLinha()
        {
            Console.WriteLine(" ");
            Console.WriteLine("----------");
            Console.WriteLine(" ");
        }
        static bool Pesquisa(string var)
        {
            return var[0] == 'A';
        }
    }
}
