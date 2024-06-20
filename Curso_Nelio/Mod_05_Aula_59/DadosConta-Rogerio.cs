using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod_05_Aula_59
{
	class DadosConta_Rogerio
	{
		/*
		 * Resolução do exercício idealizado por mim
		 * 
		#region ===> Atributos <===
		private int _numConta;

		private string _correntista;
		private string _dep_sn;

		public double SALDOCONTA { get; private set; } // esqueci o private set
		public double VDEPOSITO { get; private set; }
		public double VSAQUE { get; private set; }
		#endregion

		#region ===> Construtores <===
		public DadosConta()
		{
		}

		public DadosConta(int numConta, string nome, int saldo) 
		{
			SALDOCONTA = saldo;
		}
		#endregion

		#region ===> Propriedades <===
		public int NUMCONTA
		{
			get { return _numConta; }

			set
			{
				if (value != null && value.ToString().Length == 5)
				{
					_numConta = value;
				}
			}
		}

		public string CORRENTISTA
		{
			get { return _correntista; }

			set
			{
				if (value != null && value.Length > 1)
				{
					_correntista = value;
				}
			}
		}

		public string DEP_SN
		{
			get { return _dep_sn; }

			set
			{
				try
				{
					if (value.ToUpper() == "S" || value.ToUpper() == "N")
						_dep_sn = value;
				}
				catch
				{

				}
			}
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
				+ _numConta
				+ ", Correntista: "
				+ _correntista.ToUpper()
				+ ", ===> Saldo: R$ "
				+ SALDOCONTA.ToString("F2", CultureInfo.InvariantCulture)
				+ "<=== \r\n";
		}
		#endregion
		*/
	}
}
