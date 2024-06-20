using System;

using System.Globalization;

namespace Mod_14_Aula_202_IComparable_2_Dados.Entities
{
    class Employee : IComparable
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string csvEmployee)
        {
            string[] arrDados = csvEmployee.Split(',');
            Name = arrDados[0];
            Salary = double.Parse(arrDados[1], CultureInfo.InvariantCulture);
        }
        public override string ToString()
        {
            return "Nome: " + Name + ", Salário: R$ " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
        /*
         * Explicação da Interface IComparable:
         * Compara 2 objetos, retornando um número inteiro.
         * 
         *  Console.WriteLine("maria".CompareTo("alex")); 
         *   retorna: 1 -> maria é maior que alex
         *  Console.WriteLine("alex".CompareTo("maria"));
         *   retorna: -1 -> alex é menor que maria
         *  Console.WriteLine("maria".CompareTo("maria"));
         *   retorna: 0 -> maria é igual a maria
        */
        public int CompareTo(object obj)
        {
            if(! (obj is Employee))
            {
                throw new ArgumentException("Erro de comparação: O argumento não é Employee");
            }
            /* Jogo o conteúdo da variavel -> obj <- 
             * para uma variável temporaria para realizar 
             * a comparação das duas.
             */
            Employee temp = obj as Employee;

            return Name.CompareTo(temp.Name);
        }
    }
}
