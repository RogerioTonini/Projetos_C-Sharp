using System;
using System.Globalization;

namespace Mod_04_Aula_48
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Entre com o valor do raio: ");
			double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

			double circ = Calculadora.Circunferencia(raio);
			double volume = Calculadora.Volume(raio);

			Console.WriteLine("\r\n Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
			Console.WriteLine("\r\n Volume........: " + volume.ToString("F2", CultureInfo.InvariantCulture));
			Console.WriteLine("\r\n Valor de Pi...: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));
		}
	}
}
