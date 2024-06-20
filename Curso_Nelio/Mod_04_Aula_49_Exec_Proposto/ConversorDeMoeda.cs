namespace Mod_04_Aula_49_Exerc_Proposto
{
	class ConversorDeMoeda
	{
		public static double _taxaIOF = 1.06;

		public static double Conversor(double _vlrDolar, double _qtdReal)
		{
			return _qtdReal * _vlrDolar * _taxaIOF;
		}
	}
}
