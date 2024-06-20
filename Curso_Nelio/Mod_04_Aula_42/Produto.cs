using System.Globalization;

namespace Mod_04_Aula_42
{
	class Produto
	{
		public string Nome;
		public double Preco;
		public int Qtde;

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
