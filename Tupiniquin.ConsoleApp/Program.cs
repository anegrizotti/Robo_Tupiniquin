using System;

namespace Tupiniquim.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("TUPINIQUIM SYSTEM");
            Console.ResetColor();
            Console.WriteLine();

            bool boolContinuar = true;
            while (boolContinuar == true)
            {

                // leitura da area 
                Console.WriteLine("Digite as coordenadas do canto superior direito da área.");

                Console.Write("X: ");
                string finalX = Console.ReadLine();

                Console.Write("Y: ");
                string finalY = Console.ReadLine();

                char[] charFinalX = finalX.ToCharArray();
                char[] charFinalY = finalY.ToCharArray();
                bool continuarCoordenada = false;

                for (int i = 0; i < charFinalX.Length; i++)
                {
                    if (!(char.IsDigit(charFinalX[i])))
                    {
                        continuarCoordenada = true;
                    }
                    else if (char.IsDigit(charFinalX[i]))
                    {
                        continuarCoordenada = false;
                    }
                }

                for (int i = 0; i < charFinalY.Length; i++)
                {
                    if (!(char.IsDigit(charFinalY[i])))
                    {
                        continuarCoordenada = true;
                    }
                    else if (char.IsDigit(charFinalX[i]))
                    {
                        continuarCoordenada = false;
                    }
                }

                while (continuarCoordenada == true)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Entrada inválida.");
                    Console.ResetColor();
                    Console.WriteLine();
                    Console.WriteLine("Digite as coordenadas do canto superior direito da área.");

                    Console.Write("X: ");
                    finalX = Console.ReadLine();

                    Console.Write("Y: ");
                    finalY = Console.ReadLine();

                    charFinalX = finalX.ToCharArray();
                    charFinalY = finalY.ToCharArray();

                    for (int i = 0; i < charFinalX.Length; i++)
                    {
                        if (!(char.IsDigit(charFinalX[i])))
                        {
                            continuarCoordenada = true;
                        }
                        else if (char.IsDigit(charFinalX[i]))
                        {
                            continuarCoordenada = false;
                        }
                    }

                    for (int i = 0; i < charFinalY.Length; i++)
                    {
                        if (!(char.IsDigit(charFinalY[i])))
                        {
                            continuarCoordenada = true;
                        }
                        else if (char.IsDigit(charFinalX[i]))
                        {
                            continuarCoordenada = false;
                        }
                    }

                }

                // leitura dos comandos do robo 01
                Console.WriteLine();
                Console.WriteLine("Digite a posição inicial do robo 01.");

                Console.Write("X: ");
                int x1 = int.Parse(Console.ReadLine());
                Console.Write("Y: ");
                int y1 = int.Parse(Console.ReadLine());
                Console.Write("Direção: ");
                char direcao1 = char.Parse(Console.ReadLine());

                Console.WriteLine();

                int intFinalX = int.Parse(finalX);
                int intFinalY = int.Parse(finalY);

                while ((x1 > intFinalX || x1 < 0) || (y1 > intFinalY || y1 < 0) || (direcao1 != 'L' && direcao1 != 'O' && direcao1 != 'S' && direcao1 != 'N'))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("A posição inicial do robo 01 precisa ser um número e não pode ultrapassar o limite da area." +
                        " As direções suportadas são: Leste (L), Oeste (O), Norte (N) e Sul (S). Digite novamente.");
                    Console.ResetColor();
                    Console.WriteLine();
                    Console.Write("X: ");
                    x1 = int.Parse(Console.ReadLine());
                    Console.Write("Y: ");
                    y1 = int.Parse(Console.ReadLine());
                    Console.Write("Direção: ");
                    direcao1 = char.Parse(Console.ReadLine());
                    Console.WriteLine();

                }

                Console.Write("Digite o comando que o robo 01 deve executar: ");
                string stringComando1 = Console.ReadLine();

                char[] charComando1 = stringComando1.ToCharArray();
                Console.WriteLine();

                for (int i = 0; i < charComando1.Length; i++)
                {
                    while (charComando1[i] != 'M' && charComando1[i] != 'D' && charComando1[i] != 'E')
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("Comando inválido!");
                        Console.ResetColor();
                        Console.Write(" Digite M para mover, E para girar à esquerda e D para girar à direita: ");
                        stringComando1 = Console.ReadLine();

                        charComando1 = stringComando1.ToCharArray();
                        Console.WriteLine();

                    }
                }


                // leitura dos comandos do robo 02
                Console.WriteLine();
                Console.WriteLine("Digite a posição inicial do robo 02.");

                Console.Write("X: ");
                int x2 = int.Parse(Console.ReadLine());
                Console.Write("Y: ");
                int y2 = int.Parse(Console.ReadLine());
                Console.Write("Direção: ");
                char direcao2 = char.Parse(Console.ReadLine());

                Console.WriteLine();

                while ((x2 > intFinalX || x2 < 0) || (y2 > intFinalY || y2 < 0) || (direcao2 != 'L' && direcao2 != 'O' && direcao2 != 'S' && direcao2 != 'N'))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("A posição inicial do robo 02 não pode ultrapassar o limite da area" +
                        " e as direções suportadas são: Leste (L), Oeste (O), Norte (N) e Sul (S). Digite novamente.");
                    Console.WriteLine();
                    Console.ResetColor();
                    Console.Write("X: ");
                    x2 = int.Parse(Console.ReadLine());
                    Console.Write("Y: ");
                    y2 = int.Parse(Console.ReadLine());
                    Console.Write("Direção: ");
                    direcao2 = char.Parse(Console.ReadLine());
                    Console.WriteLine();

                }

                Console.Write("Digite o comando que o robo 02 deve executar: ");
                string stringComando2 = Console.ReadLine();

                char[] charComando2 = stringComando2.ToCharArray();
                Console.WriteLine();


                for (int i = 0; i < charComando2.Length; i++)
                {
                    while (charComando2[i] != 'M' && charComando2[i] != 'D' && charComando2[i] != 'E')
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("Comando inválido!");
                        Console.ResetColor();
                        Console.Write(" Digite M para mover, E para girar à esquerda e D para girar à direita: ");
                        stringComando2 = Console.ReadLine();

                        charComando2 = stringComando2.ToCharArray();
                        Console.WriteLine();

                    }
                }

                // verificações do robo 01, conforme digitado pelo usuario
                for (int i = 0; i < charComando1.Length; i++)
                {

                    if (direcao1 == 'L')
                    {
                        if (charComando1[i] == 'M')
                        {
                            x1 = x1 + 1;
                            if (x1 > intFinalX || x1 < 0)
                            {
                                //Console.WriteLine("Limite de X1 atingido!");
                                x1 = x1 - 1;
                                continue;
                            }
                        }
                        else if (charComando1[i] == 'D')
                        {
                            direcao1 = 'S';
                        }
                        else if (charComando1[i] == 'E')
                        {
                            direcao1 = 'N';
                        }

                        continue;

                    }

                    if (direcao1 == 'S')
                    {
                        if (charComando1[i] == 'M')
                        {
                            y1 = y1 - 1;
                            if (y1 > intFinalY || y1 < 0)
                            {
                                //Console.WriteLine("Limite de Y1 atingido!");
                                y1 = y1 - 1;
                                continue;
                            }
                        }
                        else if (charComando1[i] == 'D')
                        {
                            direcao1 = 'O';
                        }
                        else if (charComando1[i] == 'E')
                        {
                            direcao1 = 'L';
                        }

                        continue;
                    }

                    if (direcao1 == 'O')
                    {
                        if (charComando1[i] == 'M')
                        {
                            x1 = x1 - 1;
                            if (x1 > intFinalX || x1 < 0)
                            {
                                //Console.WriteLine("Limite de X1 atingido!");
                                x1 = x1 - 1;
                                continue;
                            }
                        }
                        else if (charComando1[i] == 'D')
                        {
                            direcao1 = 'N';
                        }
                        else if (charComando1[i] == 'E')
                        {
                            direcao1 = 'S';
                        }

                        continue;
                    }

                    if (direcao1 == 'N')
                    {
                        if (charComando1[i] == 'M')
                        {
                            y1 = y1 + 1;
                            if (y1 > intFinalY || y1 < 0)
                            {
                                //Console.WriteLine("Limite de Y1 atingido!");
                                y1 = y1 - 1;
                                continue;
                            }
                        }
                        else if (charComando1[i] == 'D')
                        {
                            direcao1 = 'L';
                        }
                        else if (charComando1[i] == 'E')
                        {
                            direcao1 = 'O';
                        }

                        continue;

                    }

                }


                // verificações do robo 02, conforme digitado pelo usuario
                for (int i = 0; i < charComando2.Length; i++)
                {

                    if (direcao2 == 'L')
                    {
                        if (charComando2[i] == 'M')
                        {
                            x2 = x2 + 1;
                            if (x2 > intFinalX || x2 < 0)
                            {
                                //Console.WriteLine("Limite de X2 atingido!");
                                x2 = x2 - 1;
                                continue;
                            }
                        }
                        else if (charComando2[i] == 'D')
                        {
                            direcao2 = 'S';
                        }
                        else if (charComando2[i] == 'E')
                        {
                            direcao2 = 'N';
                        }

                        continue;

                    }

                    if (direcao2 == 'S')
                    {
                        if (charComando2[i] == 'M')
                        {
                            y2 = y2 - 1;
                            if (y2 > intFinalY || y2 < 0)
                            {
                                //Console.WriteLine("Limite de Y2 atingido!");
                                y2 = y2 - 1;
                                continue;
                            }
                        }
                        else if (charComando2[i] == 'D')
                        {
                            direcao2 = 'O';
                        }
                        else if (charComando2[i] == 'E')
                        {
                            direcao2 = 'L';
                        }

                        continue;
                    }

                    if (direcao2 == 'O')
                    {
                        if (charComando2[i] == 'M')
                        {
                            x2 = x2 - 1;
                            if (x2 > intFinalX || x2 < 0)
                            {
                                //Console.WriteLine("Limite de X2 atingido!");
                                x2 = x2 - 1;
                                continue;
                            }
                        }
                        else if (charComando2[i] == 'D')
                        {
                            direcao2 = 'N';
                        }
                        else if (charComando2[i] == 'E')
                        {
                            direcao2 = 'S';
                        }

                        continue;
                    }

                    if (direcao2 == 'N')
                    {
                        if (charComando2[i] == 'M')
                        {
                            y2 = y2 + 1;
                            if (y2 > intFinalY || y2 < 0)
                            {
                                //Console.WriteLine("Limite de Y2 atingido!");
                                y2 = y2 - 1;
                                continue;
                            }
                        }
                        else if (charComando2[i] == 'D')
                        {
                            direcao2 = 'L';
                        }
                        else if (charComando2[i] == 'E')
                        {
                            direcao2 = 'O';
                        }

                        continue;

                    }

                }

                // apresentação dos resultados finais
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("A posição final do robo 01 é: " + x1 + ", " + y1 + ", " + direcao1);
                Console.WriteLine("A posição final do robo 02 é: " + x2 + ", " + y2 + ", " + direcao2);
                Console.ResetColor();

                Console.WriteLine();
                Console.Write("Deseja continuar? Digite S para sim e N para não: ");
                char charContinuar = char.Parse(Console.ReadLine());
                Console.WriteLine();

                while (charContinuar != 'S' && charContinuar != 'N')
                {
                    Console.Write("Comando inválido. Deseja continuar? Digite S para sim e N para não: ");
                    charContinuar = char.Parse(Console.ReadLine());
                    Console.WriteLine();

                }

                if (charContinuar == 'S')
                {
                    boolContinuar = true;
                }
                else if (charContinuar == 'N')
                {
                    boolContinuar = false;
                }

            }

        }
    }
}

