using System;

namespace Exercicio04.ConsoleApp
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

                Console.WriteLine("===== Tabuada! =====");
                Console.WriteLine("");
                Console.WriteLine("Programa para identificar e gerar a tabuada do numero digitado.");
                Console.WriteLine("");

                Console.Write("Escolhe um numero de 1 a 10: ");
                string inputOpt = Console.ReadLine();

                int numTab = int.Parse(inputOpt);
                int rstTab = 0;

                Console.WriteLine("");

                // linhas 32 a 53 = condicao para checar se o numero digitado eh maior do que 10 ou menor do que 0.

                if (numTab > 10)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("O numero escolhido para tabuado eh maior que 10.");
                    Console.WriteLine("Por favor, tente novamente.");
                    Console.ResetColor();
                    Console.WriteLine("");
                    Console.WriteLine("Aperte ENTER para prosseguir.");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (numTab < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("O numero escolhido para tabuado eh menor do que 0.");
                    Console.WriteLine("Por favor, tente novamente.");
                    Console.ResetColor();
                    Console.WriteLine("");
                    Console.WriteLine("Aperte ENTER para prosseguir.");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    // linhas 58 a 69 = repeticao para tabuada + output do resultado.

                    Console.WriteLine("Tabuada do numero {0}.", numTab);
                    Console.WriteLine("");

                    for (int i = 0; i <= 10; i++)
                    {
                        rstTab = numTab * i;
                        Console.WriteLine("{0} x {1} = {2}", i, numTab, rstTab);
                    }

                    Console.WriteLine("");
                    Console.WriteLine("Aperte ENTER para prosseguir.");
                    Console.ReadLine();

                    // linhas 73 a 103 = inicio e condicao do while de menu de escolha do usuario para sair da aplicao ou permanecer rodando a mesma.

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
}
