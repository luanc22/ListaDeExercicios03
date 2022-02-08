using System;
using System.Linq;

namespace Exercicio01.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // linhas 10 a 14 = inicio e condicao do while para rodar o programa ate que o usuario deseje parar.

            bool fecharApp = false;

            while (fecharApp == false)
            {
                // linhas 18 a 28 = input de dados, conversao de tipos de dados para utilizacao e declaracao de variaveis utilizadas.

                Console.WriteLine("===== Checar Maior e Menor altura =====");
                Console.WriteLine("");
                Console.WriteLine("Programa para identificar a maior e a menor altura dentro de 15 alturas.");
                Console.WriteLine("");

                Console.Write("Digite os valores separados por ponto e virgula: ");
                string inputAlt = Console.ReadLine();
                string[] inputAltArr = inputAlt.Split(new char[] {';'}, StringSplitOptions.RemoveEmptyEntries);
                double[] AltArrNums = new double[15];

                Console.WriteLine("");

                // linhas 32 a 40 = verificao se nao foram digitadas mais do que 15 alturas.

                if (inputAltArr.Length > 15)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Voce digitou mais de 15 valores, por favor, tente novamente.");
                    Console.ResetColor();
                    Console.WriteLine("");
                    Console.WriteLine("Aperte ENTER para prosseguir.");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    // linhas 41 a 52 = continuacao do programa apos validacao, troca da array de string para double para poder validar os valores, declaracao de variaveis de menor e maior altura.

                    for (int i = 0; i < inputAltArr.Length; i++)
                    {
                        AltArrNums[i] = double.Parse(inputAltArr[i]);
                    }

                    double minAlt = AltArrNums.Min();
                    double maxAlt = AltArrNums.Max();

                    // linhas 55 a 77 = validacao se foram digitamos menos do que 15 valores ou se foi passado um 0 + output do resultado caso a validacao ocorra. 

                    if(minAlt == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Voce inseriu menos do que 15 valores ou uma altura de valor 0 que nao existe.\nPor favor, tente novamente.");
                        Console.ResetColor();
                        Console.WriteLine("");
                        Console.WriteLine("Aperte ENTER para prosseguir.");
                        Console.ReadLine();
                        Console.Clear();

                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("A menor altura eh de {0} metros.", minAlt);
                        Console.WriteLine("A maior altura eh de {0} metros.", maxAlt);
                        Console.ResetColor();

                        Console.WriteLine("");
                        Console.WriteLine("Aperte ENTER para prosseguir.");
                        Console.ReadLine();

                        Console.WriteLine("");

                        // linhas 79 a 111 = inicio e condicao do while de menu de escolha do usuario para sair da aplicao ou permanecer rodando a mesma.

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
}
