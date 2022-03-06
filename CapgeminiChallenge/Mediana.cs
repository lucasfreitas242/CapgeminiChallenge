
namespace Questao1
{
    public class EncontraMediana
    {
        public int[] listaNumeros = new int[] { 9, 2, 1, 8, 4, 6, 3, 7, 5 };

        public int mediana = 0;

        public bool VerificaImparPar()
        {
            if (listaNumeros.Length % 2 == 0)
            {
                return false;
            } 
            else
            {
                return true;
            }

        }
    }
  
}
