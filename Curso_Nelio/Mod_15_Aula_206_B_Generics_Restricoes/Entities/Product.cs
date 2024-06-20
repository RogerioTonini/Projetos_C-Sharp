using System;

namespace Mod_15_Aula_206_B_Generics_Restricoes
{
    class Product : IComparable
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price) 
        {
            Name = name;
            Price = price;
        }
        public override string ToString()
        {
            return Name;
        }

        public int CompareTo(object obj)
        {
            if( ! (obj is Product))
            {
                throw new ArgumentException("Erro de arqgumento: O argumento não é um produto");
            }
            Product temp = obj as Product;
            return Price.CompareTo(temp.Price);
        }
    }
}
