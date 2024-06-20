using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod_05_Aula_55_Encapsulamento
{
	class Program
	{
		static void Main(string[] args)
		{
			Produto produto = new Produto("TV", 523.87, 10);

			/* Não aceitará a alteração de nome, pois o SET só deixa alterar
			 * se a quantidade de caracteres for MAIOR QUE 1.
			 */
			produto.SetNome("T");

			Console.WriteLine(produto.GetNome());
			Console.WriteLine(produto.GetQtde());
			Console.WriteLine(produto.GetPreco());
		}
	}
}
