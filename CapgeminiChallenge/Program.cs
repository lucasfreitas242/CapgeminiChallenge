using System;
using System.Threading;

namespace Questao1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("QUESTÃO 1 - ENCONTRAR A MEDIANA:\n");

            Console.Write("Calculando");
            Thread.Sleep(600);
            Console.Write(".");
            Thread.Sleep(700);
            Console.Write(".");
            Thread.Sleep(800);
            Console.WriteLine(".\n");
            Thread.Sleep(900);

            EncontraMediana encontraMediana = new();

            bool impar_par = encontraMediana.VerificaImparPar();

            if(impar_par == true)
            {

                Array.Sort(encontraMediana.listaNumeros);

                int posicao_valor = (encontraMediana.listaNumeros.Length + 1) / 2;
                encontraMediana.mediana = encontraMediana.listaNumeros[posicao_valor - 1];

                Console.WriteLine("A mediana é: {0} \n", encontraMediana.mediana);
                Thread.Sleep(1000);

            }
            else
            {
                Console.WriteLine("Esta lista contém um total de números pares, por favor, tente novamente.\n");
                Thread.Sleep(2000);
            }

            Console.WriteLine("FIM DA QUESTÃO 1.\n");

            Console.WriteLine("================================\n");
        }
    }
}
