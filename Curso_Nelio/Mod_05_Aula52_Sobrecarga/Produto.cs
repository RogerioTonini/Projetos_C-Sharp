using System;
using System.Globalization;

namespace Mod_05_Aula_52_Sobrecarga
{
	class Produto
	{
		public string Nome;
		public double Preco;
		public int Qtde;

		/* Como os atributos que são tipificados como numéricos, o C# não exige inicialização,
		 * se criarmos um construtor especificando este atributo, ele é considerado PADRÃO.
		 * Conforme exemplo abaixo.
		 */
		public Produto() { Qtde = 0; }

		public Produto(string nome, double preco)
		{
			Nome = nome;
			Preco = preco;
		}

		//public Produto(string nome, double preco, int qtde)
		//{
		//	Nome = nome;
		//	Preco = preco;
		//	Qtde = qtde;
		//}

		/*
		 * Aula 54 - Uso da palavra this em Construtor
		 */
		public Produto(string nome, double preco, int qtde) : this(nome, preco)
		{
			Qtde = qtde;
		}

		public double ValorTotalEmEstoque()
		{
			return Preco * Qtde;
		}

		public void AdicionarProdutos(int _qtde)
		{
			Qtde += _qtde;
		}

		public void RemoverProdutos(int _qtde)
		{
			Qtde -= _qtde;
		}

		public override string ToString()
		{
			return "\r\n Dados do Produto: "
				+ Nome
				+ ", Valor Unitário R$ "
				+ Preco.ToString("F2", CultureInfo.InvariantCulture)
				+ ", "
				+ Qtde
				+ " unidades em Estoque, Totalizando R$ "
				+ ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)
				+ "\r\n";
		}
	}
}