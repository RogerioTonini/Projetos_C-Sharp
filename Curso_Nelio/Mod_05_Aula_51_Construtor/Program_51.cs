using System;
using System.Globalization;

namespace Mod_05_Aula_51_Construtor
{
	class Program_51
	{
		static void Main(string[] args)
		{

			/*
			 * Código base para esta aula é da Aula 42
			 * Ao instanciar uma classe (neste caso Produto), ao pedir para imprimir 
			 * o produto automaticamente todas as informações serão inicializadas 
			 * nulas (caracteres) ou zeradas (números), conforme exemplo abaixo.
			 *
			 *	Produto produto = new Produto();
			 *	Console.WriteLine(produto);
			 */
			Console.WriteLine("Entre com os dados do Produto:");

			Console.Write("Nome do Produto: ");
			string nome = Console.ReadLine();

			Console.Write("Valor..........: ");
			double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

			Console.Write("Qtde em Estoque: ");
			int qtde = int.Parse(Console.ReadLine());

			Produto produto = new Produto(nome, preco, qtde);

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
