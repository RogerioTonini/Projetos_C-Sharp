using System;
using System.Globalization;

namespace Mod_05_Aula_52_Sobrecarga
{
	class Program_52
	{
		static void Main(string[] args)
		{
			/*
			 * Código base para esta aula é da Aula 42
			 */
			Console.WriteLine("Entre com os dados do Produto:");

			Console.Write("Nome do Produto: ");
			string nome = Console.ReadLine();

			Console.Write("Valor..........: ");
			double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

			//Console.Write("Qtde em Estoque: ");
			//int qtde = int.Parse(Console.ReadLine());

			Produto produto = new Produto(nome, preco);

			Produto p1 = new Produto();

			/*
			 * Aula 53 - Formas alternativas de novas formas de instanciar
			 *
			 *	Produto p1 = new Produto { Nome = "TV", Preco = 545.00, Qtde = 20 };
			 *
			 *	Produto p2 = new Produto() { Nome = "TV", Preco = 545.00, Qtde = 20 };
			*/

			Console.WriteLine(produto);

			Console.Write("-- Informe a quantidade a ser acrescida ao estoque: ");
			int qtd = int.Parse(Console.ReadLine());
			produto.AdicionarProdutos(qtd);
			Console.WriteLine(produto);

			Console.Write("-- Informe a quantidade a ser retirada do estoque: ");
			qtd = 0;
			qtd = int.Parse(Console.ReadLine());
			produto.RemoverProdutos(qtd);
			Console.WriteLine(produto);
		}
	}
}
