using System;

namespace Mod_04_Aula_48
{
	class Calculadora
	{
		/*
		 * Ao colocar a palavra STATIC, o método torna-se automaticamente ESTÁTICO.
		 * Ao utiliza-lo em qualquer parte do programa, não é necessário instancia-lo.
		 */
		public static double Pi = 3.14;

		public static double Circunferencia(double _raio)
		{
			return 2.0 * Pi * _raio;
		}

		public static double Volume(double _raio)
		{
			return 4.0 / 3.0 * Pi * Math.Pow(_raio, 3);
		}
	}
}
