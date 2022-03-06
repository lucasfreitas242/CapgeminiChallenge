using System;
using System.Linq;
using System.Threading;

namespace Questao2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("QUESTÃO 2 - CONTAR DIFERENÇAS\n");
            
            NumerosDiferentes numerosDiferentes = new();

            Console.Write("Contando");
            Thread.Sleep(600);
            Console.Write(".");
            Thread.Sleep(700);
            Console.Write(".");
            Thread.Sleep(800);
            Console.WriteLine(".\n");
            Thread.Sleep(900);

            int paresDiferentes = numerosDiferentes.ContaParesDiferentes();

            Console.WriteLine("O número de Pares diferentes é de: {0}\n", paresDiferentes);
            Thread.Sleep(1000);

            Console.WriteLine("FIM DA QUESTÃO 2\n");

            Console.WriteLine("================================\n");
        }
    }
}
