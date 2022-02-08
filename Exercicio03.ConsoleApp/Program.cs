using System;

namespace Exercicio03.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // linhas 9 a 17 = declarao de variaveis

            Console.WriteLine("===== Soma de numeros impares multiplos de tres entre 1 e 500 =====");
            Console.WriteLine("");
            Console.WriteLine("Programa para identificar e somar todos os multiplos de tres entre 1 e 500.");
            Console.WriteLine("");

            int numCnt;
            int somTot = 0;

            // linhas 21 a 40 = repeticao para pegar todos os numeros e output de resultado.

            for (numCnt = 1; numCnt >= 1 && numCnt <= 500; numCnt++)
            {
                int chkNum = numCnt % 2;
                int chkThr = numCnt % 3;

                if (chkNum != 0 && chkThr == 0)
                {
                    somTot = numCnt + somTot;
                }
                else
                {
                    continue;
                }
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("O resultado total da soma fica: {0}.", somTot);
            Console.ResetColor();

            Console.WriteLine("");

            // linhas 44 e 45 = finalizacao do programa.

            Console.WriteLine("Aperte ENTER para fechar o programa.");
            Console.ReadLine();
        }
    }
}
