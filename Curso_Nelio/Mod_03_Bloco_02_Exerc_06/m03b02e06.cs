using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod_03_Bloco_02_Exerc_06
{
	class m03b02e06
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Informe um valor: ");
			double _valor = double.Parse(Console.ReadLine());

			if (_valor < 0.0 || _valor > 100.0)
				Console.WriteLine("Valor inválido!");
			else if (_valor <= 25.0)
				Console.WriteLine("O valor esta no intervalo: [0, 25]");
			else if (_valor <= 50.0)
				Console.WriteLine("O valor esta no intervalo: [25, 50]");
			else if (_valor <= 75.0)
				Console.WriteLine("O valor esta no intervalo: [50, 75]");
			else 
				Console.WriteLine("O valor esta no intervalo: [75, 100]");
		}
	}
}
