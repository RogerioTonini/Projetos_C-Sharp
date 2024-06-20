using System;
using System.Globalization;

namespace Mod_04_Aula_46
{
	class Program
	{
		static double Pi = 3.14;

		static void Main(string[] args)
		{
			Console.Write("Entre com o valor do raio: ");
			double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

			double circ = Circunferencia(raio);
			double volume = Volume(raio);

			Console.WriteLine("\r\n Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
			Console.WriteLine("\r\n Volume........: " + volume.ToString("F2", CultureInfo.InvariantCulture));
			Console.WriteLine("\r\n Valor de Pi...: " + Pi.ToString("F2", CultureInfo.InvariantCulture));
		}

		static double Circunferencia(double _raio)
		{
			return 2.0 * Pi * _raio;
		}

		static double Volume(double _raio)
		{
			return 4.0 / 3.0 * Pi * Math.Pow(_raio, 3);
		}
	}
}
