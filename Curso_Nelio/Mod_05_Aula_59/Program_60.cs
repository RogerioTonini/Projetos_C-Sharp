using System;
using System.Globalization;

namespace Mod_05_Aula_60_Exerc_Proposto
{
	class csPrincipal
	{
		static void Main(string[] args)
		{
			DadosConta dadosconta;

			Console.WriteLine("Entre com os dados da Conta Corrente / Correntista");

			Console.Write("Informe o número da conta corrente: ");
			int numConta = int.Parse(Console.ReadLine());

			Console.Write("Informe o nome do correntista.....: ");
			string NomeCorrentista = Console.ReadLine();

			Console.Write("\r\n Haverá depósito inicial...........: ");
			char depSN = char.Parse(Console.ReadLine());

			if (depSN == 'S' || depSN == 's')
			{
				Console.Write("Informe valor do depósito inicial.: ");
				double saldoInicial = double.Parse(Console.ReadLine());

				dadosconta = new DadosConta(numConta, NomeCorrentista, saldoInicial);
			}
			else
				dadosconta = new DadosConta(numConta, NomeCorrentista);

			Console.WriteLine();
			Console.WriteLine(dadosconta);
			Console.WriteLine();

			Console.Write("Informe um valor para Depósito: ");
			double _valorDep = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			dadosconta.OperacaoDeposito(_valorDep);

			Console.WriteLine(dadosconta);
			Console.WriteLine();

			Console.Write("Informe um valor para Saque...: ");
			double _valorSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			dadosconta.OperacaoSaque(_valorSaque);
			Console.WriteLine(dadosconta);

			Console.ReadKey();
		}

		//public void MostraDadosConta()
		//{
		//	Console.WriteLine(dadosconta);
		//	Console.WriteLine();
		//}
	}
}
