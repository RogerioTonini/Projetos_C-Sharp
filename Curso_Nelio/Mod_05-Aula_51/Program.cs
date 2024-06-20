using System;
using System.Globalization;

namespace Mod_05_Aula_51
{
	class Program
	{
		static void Main(string[] args)
		{
			/*
			 * Para o programa funcionar, a classe Produto exige que os valores sejam passados para a classe,
			 * a mesma não aceita valores vazio.
			 */

			Console.WriteLine("Entre com os dados do Produto:");

			Console.Write("Nome do Produto: ");
			string _nome = Console.ReadLine();

			Console.Write("Valor..........: ");
			double _preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

			Console.Write("Qtde em Estoque: ");
			int _qtde = int.Parse(Console.ReadLine());

			Produto produto = new Produto(_nome, _preco, _qtde);

			Console.WriteLine(produto);

			Console.Write("-- Informe a quantidade a ser acrescida ao estoque: ");
			_qtde = int.Parse(Console.ReadLine());
			produto.AdicionarProdutos(_qtde);
			Console.WriteLine(produto);

			Console.Write("-- Informe a quantidade a ser retirada do estoque: ");
			_qtde = int.Parse(Console.ReadLine());
			produto.RemoverProdutos(_qtde);
			Console.WriteLine(produto);
		}
	}
}
