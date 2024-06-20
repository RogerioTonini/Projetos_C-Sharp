using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod_05_Aula_56_Properties
{
	class Program
	{
		static void Main(string[] args)
		{
			Produto produto = new Produto("TV", 523.87, 10);

			/* Não aceitará a alteração de nome, pois o SET só deixa alterar
			 * se a quantidade de caracteres for MAIOR QUE 1.
			 */
			produto.NOME = "0";

			Console.WriteLine(produto.NOME);
			Console.WriteLine(produto.QTDE);
			Console.WriteLine(produto.PRECO);
		}
	}
}
