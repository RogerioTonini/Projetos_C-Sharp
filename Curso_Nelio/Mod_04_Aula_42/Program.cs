using System;
using System.Globalization;

namespace Mod_04_Aula_42
{
	class Program
	{
		static void Main(string[] args)
		{
			Produto produto = new Produto();

			Console.WriteLine("Entre com os dados do Produto:");
			
			Console.Write("Nome do Produto: ");
			produto.Nome = Console.ReadLine();

			Console.Write("Valor..........: ");
			produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

			Console.Write("Qtde em Estoque: ");
			produto.Qtde = int.Parse(Console.ReadLine());

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
