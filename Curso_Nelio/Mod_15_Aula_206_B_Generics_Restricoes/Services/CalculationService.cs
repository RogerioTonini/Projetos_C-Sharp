using System;
using System.Collections.Generic;


namespace Mod_15_Aula_206_B_Generics_Restricoes.Services
{
    /* Classe que lê qualquer tipo de dado */

    class CalculationService
    {
        /*
         * A Generics pode ser implementada para:
         * Classes, Métodos ou Interfaces
         */
        public T Maximo<T>(List<T> lista) where T : IComparable
        {
            if (lista.Count == 0)
            {
                throw new ArgumentException("The list can not be empty");
            }

            /* 
             * Lê a -> lista <-, comparando valor de cada elemento.
             */
            T valorMaximo = lista[0];
            for (int cont = 1; cont < lista.Count; cont++)
            {
                if (lista[cont].CompareTo(valorMaximo) > 0)
                {
                    valorMaximo = lista[cont];
                }
            }
            return valorMaximo;
        }
    }
}
