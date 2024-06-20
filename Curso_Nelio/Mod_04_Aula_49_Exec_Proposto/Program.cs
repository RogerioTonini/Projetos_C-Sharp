using System;
using System.Globalization;

namespace Mod_04_Aula_49_Exerc_Proposto
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Valor dólar no dia.............: ");
			double vlrDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

			Console.Write("Quantidade de dolares a comprar: ");
			double qtdDolares = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

			Console.WriteLine("\r\n Valor em R$: " + ConversorDeMoeda.Conversor(vlrDolar, qtdDolares).ToString("F2", CultureInfo.InvariantCulture));
		}
	}
}
