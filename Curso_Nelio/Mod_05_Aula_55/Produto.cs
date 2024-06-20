using System.Globalization;

namespace Mod_05_Aula_55_Encapsulamento
{
	class Produto
	{
		#region ==> Atributos <==
			/*
			* Por convenção no C# qdo definimos os atributos os mesmos devem
			* ser iniciados pelo caracter "_" e a primeira letra minúscula.
			* 
			* Para realização do Encapsulamento, é OBRIGATÓRIO definir 
			* os atributos como PRIVATE.
			*/
			private string _nome;
			private double _preco;
			private int _qtde;
		#endregion

		#region ===> Construtores <===
		/*
		 * Este construtor inicializa os Atributos sem valores
		 */
		public Produto()
		{
		}
		/*
		 * Este Construtor recebe o conteúdo dos Atributos
		 */
		public Produto(string nome, double preco, int qtde)
		{
			_nome = nome;
			_preco = preco;
			_qtde = qtde;
		}
		#endregion

		#region ==> Encapsulamento <==
		/*
		 * Obtém o valor do Atributo
		 */
		public string GetNome()
		{
			return _nome;
		}
		/*
		 * Define / Altera o valor do Atributo
		 */
		public void SetNome(string nome)
		{
			if (nome != null && nome.Length > 1)
			{
				_nome = nome;
			}
		}

		public double GetPreco()
		{
			return _preco;
		}

		public int GetQtde()
		{
			return _qtde;
		}
		#endregion

		public double ValorTotalEmEstoque()
		{
			return _preco * _qtde;
		}

		public void AdicionarProdutos(int _qtde)
		{
			_qtde += _qtde;
		}

		public void RemoverProdutos(int _qtde)
		{
			_qtde -= _qtde;
		}

		public override string ToString()
		{
			return "\r\n Dados do Produto: "
				+ _nome
				+ ", Valor Unitário R$ "
				+ _preco.ToString("F2", CultureInfo.InvariantCulture)
				+ ", "
				+ _qtde
				+ " unidades em Estoque, Totalizando R$ "
				+ ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)
				+ "\r\n";
		}
	}
}
