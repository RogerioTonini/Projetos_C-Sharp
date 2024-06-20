using System;
using System.Collections.Generic;

namespace Mod_15_Aula_206_A_Generics_Restricoes.Services
{
    /* Classe somente para números inteiros */
    class CalculationService
    {
        public int Maximo(List<int> lista)
        {
            if (lista.Count == 0)
            {
                throw new ArgumentException("The list can not be empty");
            }

            /* 
             * Lê a -> lista <-, comparando valor de cada elemento.
             */
            int valorMaximo = lista[0];
            for (int cont = 1; cont < lista.Count; cont++)
            {
                if(lista[cont] > valorMaximo)
                {
                    valorMaximo = lista[cont];
                }
            }
            return valorMaximo;
        }
    }
}
