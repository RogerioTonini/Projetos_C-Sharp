using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod_03_Bloco_02_Exerc_04
{
	class m03b02e04
	{
		static void Main(string[] args)
		{
			decimal totalhoras = 0;

			Console.WriteLine("Informe a hora inicial: ");
			decimal hrinicial = decimal.Parse(Console.ReadLine());

			Console.WriteLine("Informe a hora final: ");
			decimal hrfinal = decimal.Parse(Console.ReadLine());

			// Performático
			if (hrinicial < hrfinal)
				totalhoras = hrfinal - hrinicial;
			else
				totalhoras = 24 - hrinicial + hrfinal;

			// Instrutivo
			//if (hrfinal < hrinicial)
			//	totalhoras = (24 - hrinicial) + hrfinal;
			//else if (hrinicial == hrfinal)
			//	totalhoras = 24;
			//else
			//	totalhoras = hrfinal - hrinicial;

			Console.WriteLine(totalhoras);
		}
	}
}
