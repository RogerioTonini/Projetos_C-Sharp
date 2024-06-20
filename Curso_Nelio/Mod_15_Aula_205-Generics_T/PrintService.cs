using System;
using System.Linq;

namespace Mod_15_Aula_204
{
    /* Quando se cria uma classe tipificando <T> (pode ser qq outra letra) (deve ser maúscula).
     * Desta forma, a classe pode ser reutilizada para qualquer tipo de dados: INT, STRING, OBJECT.
     * A tipagem dos dados é < type safety >, ou seja, o programador pode criar algo e o compilador não 
     * detectar o erro. Este somente será visto em tepo de execução.
     * Performático: Não há a necessidade de realizar conversões de tipos de Dados (Casting / Uncasting).
     */
    class PrintService<T>
    {
        private T[] _values = new T[10];
        private int _count = 0;

        /* Adiciona um elemento a classe Print Service */
        public void AddValue(T value)
        {
            if (_count == 10)
            {
                throw new InvalidOperationException("PrintService is full.");
            }
            _values[_count] = value;
            _count++;
        }

        /* Retornar o primeiro elemento da classe PrintService */
        public T First()
        {
            if (_count == 0)
            {
                throw new InvalidOperationException("PrintService is empty.");
            }
            return _values[0];
        }

        /* Imprimir na tela os elementos do PrintService */
        public void Print()
        {
            Console.Write("[");
            for (int cont = 0; cont < (_count - 1); cont++)
            {
                Console.Write(_values[cont] + ", ");
            }
            if (_count > 0)
            {
                Console.Write(_values[(_count - 1)]);
            }
            Console.WriteLine("]");
        }
    }
}

