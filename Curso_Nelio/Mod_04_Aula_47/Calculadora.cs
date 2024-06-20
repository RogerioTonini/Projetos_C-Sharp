using System;

namespace Mod_04_Aula_47
{
	class Calculadora
	{
		public double Pi = 3.14;

		public double Circunferencia(double _raio)
		{
			return 2.0 * Pi * _raio;
		}

		public double Volume(double _raio)
		{
			return 4.0 / 3.0 * Pi * Math.Pow(_raio, 3);
		}
	}
}
