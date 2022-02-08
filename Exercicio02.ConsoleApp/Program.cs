using System;

namespace Exercicio02.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // linhas 9 a 16 = declarao de varivel

            Console.WriteLine("===== Numeros impares entre 100 e 200 =====");
            Console.WriteLine("");
            Console.WriteLine("Programa para identificar todos os numeros impares entre 100 e 200.");
            Console.WriteLine("");

            int numCnt;

            // linhas 20 a 40 = repeticao para pegar todos os numeros e output de resultado.

            Console.WriteLine("======================");
            Console.WriteLine("");

            for (numCnt = 100; numCnt >= 100 && numCnt <= 200; numCnt++)
            {
                int chkNum = numCnt % 2;

                if (chkNum != 0)
                {
                    Console.WriteLine("{0}", numCnt);
                }
                else
                {
                    continue;
                }
            }

            Console.WriteLine("");
            Console.WriteLine("======================");

            Console.WriteLine("");

            // linhas 39 e 40 = finalizacao do programa.

            Console.WriteLine("Aperte ENTER para fechar o programa.");
            Console.ReadLine();
        }
    }
}
