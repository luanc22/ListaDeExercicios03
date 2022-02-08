using System;

namespace Exercicio05.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // linhas 9 a 13 = inicio e condicao do while para rodar o programa ate que o usuario deseje parar.

            bool fecharApp = false;

            while (fecharApp == false)
            {
                // linhas 17 a 28 = input de dados, conversao de tipos de dados para utilizacao e declaracao de variaveis utilizadas.

                Console.WriteLine("===== Fatorial! =====");
                Console.WriteLine("");
                Console.WriteLine("Programa para identificar e gerar o fatorial do numero digitado.");
                Console.WriteLine("");

                Console.Write("Escolhe um numero inteiro: ");
                string inputOpt = Console.ReadLine();

                int numFat = int.Parse(inputOpt);
                int rstFat = 1;

                Console.WriteLine("");

                // linhas 32 a 45 = repeticao para o fatorial + output do resultado.

                for (int i = numFat; i > 0; i--)
                {
                    Console.Write(i + " x ");
                    rstFat = i * rstFat;
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(" = {0}.", rstFat);
                Console.ResetColor();
                Console.WriteLine("");

                Console.WriteLine("");
                Console.WriteLine("Aperte ENTER para prosseguir.");
                Console.ReadLine();

                // linhas 49 a 79 = inicio e condicao do while de menu de escolha do usuario para sair da aplicao ou permanecer rodando a mesma.

                bool opcaoValida = false;

                while (opcaoValida == false)
                {
                    Console.WriteLine("Caso deseje realizar outra operacao, digite 1 e aperte ENTER.");
                    Console.WriteLine("Caso deseje fechar o programa, digite 0 e aperte ENTER.");
                    Console.Write("Opcao escolhida: ");
                    string fecharBotao = Console.ReadLine();

                    if (fecharBotao == "0")
                    {
                        fecharApp = true;
                        opcaoValida = true;
                    }
                    else if (fecharBotao == "1")
                    {
                        Console.Clear();
                        opcaoValida = true;
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Opcao invalida, selecione uma opcao valida!");
                        Console.ResetColor();
                        Console.WriteLine("");
                        Console.WriteLine("Aperte ENTER para prosseguir.");
                        Console.ReadLine();
                        continue;
                    }
                }
            }
        }
    }
}
