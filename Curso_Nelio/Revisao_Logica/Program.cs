using System;
using System.Globalization;
using System.Collections.Generic;

namespace Revisao_Logica
{
	class Program
	{
		static void Main(string[] args)
		{
            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);
            Console.WriteLine("Você digitou:");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Entre com seu nome completo: ");
            string nome1 = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem sua casa: ");
            int qtde = int.Parse(Console.ReadLine());

            Console.WriteLine("Infome o preço de um produto: ");
            decimal valor = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Infome seu sobrenome, idade e altura (na mesma linha): ");
            string[] matriz = Console.ReadLine().Split();

            Console.WriteLine("");
            Console.WriteLine(nome);
            Console.WriteLine(qtde);
            Console.WriteLine(valor.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(matriz[0]);
            Console.WriteLine(int.Parse(matriz[1]));
            Console.WriteLine(decimal.Parse(matriz[2]));
        }
    }
}
