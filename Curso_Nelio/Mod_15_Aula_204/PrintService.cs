using System;

namespace Mod_15_Aula_204
{
    class PrintService
    {
        private int[] _values = new int[10];
        private int _count = 0;

        /* Adiciona um elemento a classe Print Service */
        public void AddValue(int value)
        { 
            if (_count == 10)
            {
                throw new InvalidOperationException("PrintService is full.");
            }
            _values[_count] = value;
            _count++;
        }

        /* Retornar o primeiro elemento da classe PrintService */
        public int First()
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
