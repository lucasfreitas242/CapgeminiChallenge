
using System.Collections.Generic;

namespace Questao2
{
    public class NumerosDiferentes
    {
        public int[] listaNumeros = new int[] {1, 5, 3, 4, 2 };

        public int diferentes = 2;

        public int ContaParesDiferentes()
        {
            int count = 0;

            for (int i = 0; i < listaNumeros.Length; i++)
            {
                for (int j = i + 1; j < listaNumeros.Length; j++)
                {
                    if (listaNumeros[i] - listaNumeros[j] == diferentes ||
                        listaNumeros[j] - listaNumeros[i] == diferentes)
                        count++;
                }
            }
            return count;
    }
    }

    
}
