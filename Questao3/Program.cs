using System;
using System.Threading;

namespace Questao3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("QUESTÃO 3 - ENCRIPTAR TEXTOS\n");
            Encriptador encriptador = new();

            Console.Write("Encriptando");
            Thread.Sleep(600);
            Console.Write(".");
            Thread.Sleep(700);
            Console.Write(".");
            Thread.Sleep(800);
            Console.WriteLine(".\n");
            Thread.Sleep(900);

            string texto = encriptador.TextoSemEspacos() ;

            int quantidadeCaracteres = encriptador.TextoSemEspacos().Length;

            int separador = 0;

            int linha = (int)Math.Floor(Math.Sqrt(quantidadeCaracteres));

            int coluna = (int)Math.Ceiling(Math.Sqrt(quantidadeCaracteres));

            if (linha * coluna < quantidadeCaracteres)
            {
                linha = coluna;
            }

            char[,] matrizBase = new char[linha, coluna];

            for (int i = 0; i < linha; i++)
            {
                for (int j = 0; j < coluna; j++)
                {
                    if (separador < texto.Length)
                    {
                        matrizBase[i, j] = texto[separador];
                        separador++;
                    }
                }
            }

            for (int i = 0; i < linha; i++)
            {
                for (int j = 0; j < coluna; j++)
                {
                    if (matrizBase[j, i] == 0)
                    {
                        break;
                    }
                    Console.Write(matrizBase[j, i]);
                }
                Console.Write(" ");
            }

            Console.WriteLine(" \n");
            Thread.Sleep(1000);



            Console.WriteLine("FIM DA QUESTÃO 3\n");

            Console.WriteLine("================================\n");
            


        }
    }
}
