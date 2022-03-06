
namespace Questao1
{
    public class EncontraMediana
    {
        public int[] listaNumeros = new int[] { 9, 2, 1, 4, 6 };

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
