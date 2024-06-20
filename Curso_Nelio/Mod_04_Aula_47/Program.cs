using System;
using System.Globalization;

namespace Mod_04_Aula_47
{
	class Program
	{
		static void Main(string[] args)
		{
			Calculadora calc = new Calculadora();

			Console.Write("Entre com o valor do raio: ");
			double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

			double circ = calc.Circunferencia(raio);
			double volume = calc.Volume(raio);

			Console.WriteLine("\r\n Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
			Console.WriteLine("\r\n Volume........: " + volume.ToString("F2", CultureInfo.InvariantCulture));
			Console.WriteLine("\r\n Valor de Pi...: " + calc.Pi.ToString("F2", CultureInfo.InvariantCulture));
		}
	}
}
