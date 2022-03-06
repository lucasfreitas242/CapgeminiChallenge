
using System.Collections.Generic;

namespace Questao2
{
    public class NumerosDiferentes
    {
        public int[] listaNumeros = new int[] { 8, 12, 16, 4, 0, 20 };

        public int diferentes = 4;

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
