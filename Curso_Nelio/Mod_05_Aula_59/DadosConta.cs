using System.Globalization;

namespace Mod_05_Aula_60_Exerc_Proposto
{
	class DadosConta
	{
		#region ===> Atributos <===
			public int NUMCONTA { get; private set; }
			public string CORRENTISTA { get; set; }
			public double SALDOCONTA { get; private set; } 
		#endregion

		#region ===> Construtores <===
			public DadosConta(int numConta, string nome)
			{
				CORRENTISTA = nome;
				NUMCONTA = numConta;
			}

			public DadosConta(int numConta, string nome, double depInicial) : this (numConta, nome)
			{
				OperacaoDeposito(depInicial);
			}
		#endregion

		#region ==> Métodos Personalizados <==
			public void OperacaoDeposito(double _valor)
			{
				SALDOCONTA += _valor;
			}

			public void OperacaoSaque(double _valor)
			{
				SALDOCONTA -= (_valor + 5);
			}

			public override string ToString()
			{
				return "\r\n Dados da conta atualizados: "
					+ "\r\n Conta: "
					+ NUMCONTA
					+ ", Correntista: "
					+ CORRENTISTA.ToUpper()
					+ ", ===> Saldo: R$ "
					+ SALDOCONTA.ToString("F2", CultureInfo.InvariantCulture)
					+ "<=== \r\n";
			}
		#endregion
	}
}
