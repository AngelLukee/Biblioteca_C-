using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MathGame {
    internal class MainClassMathGame {
        static int num1, num2, num3, num4, escolha, resposta;
        static Random rand = new Random();
        static List<string> info = new List<string>();
      
        static void Main(string[] args) {
        inicio:
            
            Console.WriteLine("--Jogo de matemática--\n");
            Console.WriteLine("Escolha as opções abaixo:");
            Console.WriteLine("1 --> Soma\n2 --> Subtração\n3 --> Multiplicação\n4 --> Divisão\n5 --> Informações de jogos anteriores\n6 --> Sair do jogo");
            escolha = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (escolha) {
                case 1:

                    GameSoma();
                    info.Add("Jogo foi feito em --> " + DateTime.Now);//Adicionando na lista cada vez que o jogador escolha jogar
                    Console.Clear();
                    goto inicio;
                    

                case 2:

                    GameSubtracao();
                    info.Add("Jogo foi feito em --> " + DateTime.Now);
                    Console.Clear();
                    goto inicio;
                    

                case 3:

                    GameMultiplicacao();
                    info.Add("Jogo foi feito em --> " + DateTime.Now);
                    Console.Clear();
                    goto inicio;
                    

                case 4:
                    GameDivisao();
                    info.Add("Jogo foi feito em --> " + DateTime.Now);
                    Console.Clear();
                    goto inicio;
                case 5:

                    Informacoes();
                    break;

                case 6:
                    Console.WriteLine("Saindo do jogo...");
                    break;

                default:
                    Console.WriteLine("Número não informado");
                    break;
            }
        }
        public static void GameSoma() {

            for(int i = 0; i < 4; i++) {
            Randomizador();
            Console.Clear();
            Console.WriteLine("Qual valor de:\n" + num1 + " + " + num2);
            resposta = int.Parse(Console.ReadLine());


                if(num1 + num2 == resposta) {
                    Console.WriteLine("Resposta correta\nPressione qualquer tecla para próxima questão");
                    Console.ReadKey();
                }

                else {
                    Console.WriteLine("Reposta errada\nPressione qualquer tecla para a próxima questão");
                    Console.ReadKey();
                }
            }
        }
        
        public static void GameSubtracao() {
            for (int i = 0; i < 4; i++) {
                Randomizador();
                Console.Clear();
                Console.WriteLine("Qual valor de:\n" + num1 + " - " + num2);
                resposta = int.Parse(Console.ReadLine());


                if (num1 - num2 == resposta) {

                    if(i < 3) {
                       Console.WriteLine("Resposta correta\nPressione qualquer tecla para próxima questão");
                       Console.ReadKey();
                    }
                    else {
                        Console.WriteLine("Resposta correta\nPressione qualquer tecla para voltar ao menu");
                        Console.ReadKey();
                    }
                    
                }

                else {
                    if(i < 3) {
                        Console.WriteLine("Reposta errada\nPressione qualquer tecla para a próxima questão");
                        Console.ReadKey();
                    }
                    else {
                        Console.WriteLine("Resposta errada\nPressione qualquer tecla para voltar ao menu");
                        Console.ReadKey();
                    }
                }
            }
        }

        public static void GameMultiplicacao() {
            for (int i = 0; i < 4; i++) {
                Randomizador();
                Console.Clear();
                Console.WriteLine("Qual valor de:\n" + num1 + " * " + num2);
                resposta = int.Parse(Console.ReadLine());


                if (num1 * num2 == resposta) {

                    if (i < 3) {
                        Console.WriteLine("Resposta correta\nPressione qualquer tecla para próxima questão");
                        Console.ReadKey();
                    }
                    else {
                        Console.WriteLine("Resposta correta\nPressione qualquer tecla para voltar ao menu");
                        Console.ReadKey();
                    }

                }

                else {
                    if (i < 3) {
                        Console.WriteLine("Reposta errada\nPressione qualquer tecla para a próxima questão");
                        Console.ReadKey();
                    }
                    else {
                        Console.WriteLine("Resposta errada\nPressione qualquer tecla para voltar ao menu");
                        Console.ReadKey();
                    }
                }
            }
        }

        public static void GameDivisao() {
            for (int i = 0; i < 4; i++) {
                Randomizador();
                Console.Clear();
                Console.WriteLine("Qual valor de:\n" + num1 + " Dividido por " + num2);
                resposta = int.Parse(Console.ReadLine());


                if (num1 / num2 == resposta) {

                    if (i < 3) {
                        Console.WriteLine("Resposta correta\nPressione qualquer tecla para próxima questão");
                        Console.ReadKey();
                    }
                    else {
                        Console.WriteLine("Resposta correta\nPressione qualquer tecla para voltar ao menu");
                        Console.ReadKey();
                    }

                }

                else {
                    if (i < 3) {
                        Console.WriteLine("Reposta errada\nPressione qualquer tecla para a próxima questão");
                        Console.ReadKey();
                    }
                    else {
                        Console.WriteLine("Resposta errada\nPressione qualquer tecla para voltar ao menu");
                        Console.ReadKey();
                    }
                }
            }
         }

        public static void Randomizador() {
            num1 = rand.Next(1, 20);
            num2 = rand.Next(1, 20);
            num3 = rand.Next(1, 10) * 2;
            num4 = rand.Next(1, 10) * 2;
            
        }

        public static void Informacoes() {
            if (info.Count == 0) {
                Console.WriteLine("Nenhum jogo ainda foi encontrado");
            }
            else {
                for (int i = 0; i < info.Count; i++) {
                    Console.WriteLine(info[i]);
                }
            }
        }
    }
}
