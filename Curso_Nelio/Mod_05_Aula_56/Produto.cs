using System.Globalization;

namespace Mod_05_Aula_56_Properties
{
	// Esta classe só poderá ser acessada por chamadas que estiverem dentro deste Projeto
	class Produto
	{
		/*
		 * Ordem sugerida para implementação de Membros das Classes
		 * 
		 * 1-) Atributos Privados
		 * 2-) Propriedades Autoimplementadas
		 * 3-) Construtores
		 * 4-) Propriedades customizadas
		 * 5-) Outros métodos da classe
		 */
		#region ===> Atributos Privados <===
		private string _nome;
		/*
		* Auto Properties (Propriedades Autoimplementadas)
		* GET - Obter
		* SET - Definir, Alterar
		*/
		public double PRECO { get; private set; }
		public int    QTDE  { get; private set; }
		#endregion

		#region ===> Construtores <===
		public Produto() { }

		public Produto(string nome, double preco, int qtde)
		{
			_nome = nome;
			PRECO = preco;
			QTDE = qtde;
		}
		#endregion

		#region ===> Propriedades Customizadas <===
		public string NOME
		{
			get { return _nome; }

			set
			{
				/*
				 * A palavra VALUE substitui a variavel que seria recebida 
				 * em um método.
				 */
				if (value != null && value.Length > 1)
				{
					_nome = value;
				}
			}
		}
		#endregion

		#region ===> Outros métodos <===
		public double ValorTotalEmEstoque()
		{
			return PRECO * QTDE;
		}

		public void AdicionarProdutos(int _qtde)
		{
			QTDE += _qtde;
		}

		public void RemoverProdutos(int _qtde)
		{
			QTDE -= _qtde;
		}

		public override string ToString()
		{
			return "\r\n Dados do Produto: "
				+ _nome
				+ ", Valor Unitário R$ "
				+ PRECO.ToString("F2", CultureInfo.InvariantCulture)
				+ ", "
				+ QTDE
				+ " unidades em Estoque, Totalizando R$ "
				+ ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)
				+ "\r\n";
		}
		#endregion
	}
}
