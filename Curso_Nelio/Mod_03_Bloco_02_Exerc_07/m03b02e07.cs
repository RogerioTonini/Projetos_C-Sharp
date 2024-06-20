using System;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod_03_Bloco_02_Exerc_07
{
	class m03b02e07
	{
		static void Main(string[] args)
		{
			/*
			* Leia 2 valores com uma casa decimal(x e y), que devem representar as coordenadas
			* de um ponto em um plano. A seguir, determine qual o quadrante ao qual pertence o
			* ponto, ou se está sobre um dos eixos cartesianos ou na origem(x = y = 0).
			* Se o ponto estiver na origem, escreva a mensagem “Origem”.
			* Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a
			* situação.
			*/
			decimal x = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			decimal y = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

			if (x > 0 && y > 0)
				Console.WriteLine("Q1");
			else if (x < 0 && y > 0)
				Console.WriteLine("Q2");
			else if (x > 0 && y < 0)
				Console.WriteLine("Q3");
			else if (x < 0 && y < 0)
				Console.WriteLine("Q4");
			else if (x == 0)
				Console.WriteLine("Eixo X");
			else if (y == 0)
				Console.WriteLine("Eixo Y");
			else
				Console.WriteLine("Origem");
		}
	}
}
