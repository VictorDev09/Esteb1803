namespace JogoDaVelha
{
    using System;

    public class JogoDaVelha
    {
        static char[,] tabuleiro = new char[3, 3];
        static int jogadorAtual = 1;

        public static void Main(string[] args)
        {
            InicializarTabuleiro();
            Jogar();
        }

        static void InicializarTabuleiro()
        {
            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 3; coluna++)
                {
                    tabuleiro[linha, coluna] = ' ';
                }
            }
        }

        static void Jogar()
        {
            bool jogoAcabou = false;
            int jogadas = 0;

            while (!jogoAcabou)
            {
                DesenharTabuleiro();
                FazerJogada();
                jogadas++;

                if (VerificarVitoria())
                {
                    DesenharTabuleiro();
                    Console.WriteLine($"Jogador {jogadorAtual} venceu!");
                    jogoAcabou = true;
                }
                else if (jogadas == 9)
                {
                    DesenharTabuleiro();
                    Console.WriteLine("Empate!");
                    jogoAcabou = true;
                }
                else
                {
                    jogadorAtual = jogadorAtual == 1 ? 2 : 1;
                }
            }
        }

        static void DesenharTabuleiro()
        {
            Console.Clear();
            Console.WriteLine("  0 1 2");
            for (int linha = 0; linha < 3; linha++)
            {
                Console.Write($"{linha} ");
                for (int coluna = 0; coluna < 3; coluna++)
                {
                    Console.Write($"{tabuleiro[linha, coluna]} ");
                }
                Console.WriteLine();
            }
        }

        static void FazerJogada()
        {
            int linha, coluna;
            bool jogadaValida = false;

            do
            {
                Console.Write($"Jogador {jogadorAtual}, digite a linha (0-2): ");
                if (int.TryParse(Console.ReadLine(), out linha) && linha >= 0 && linha < 3)
                {
                    Console.Write($"Jogador {jogadorAtual}, digite a coluna (0-2): ");
                    if (int.TryParse(Console.ReadLine(), out coluna) && coluna >= 0 && coluna < 3)
                    {
                        if (tabuleiro[linha, coluna] == ' ')
                        {
                            tabuleiro[linha, coluna] = jogadorAtual == 1 ? 'X' : 'O';
                            jogadaValida = true;
                        }
                        else
                        {
                            Console.WriteLine("Posição já ocupada. Tente novamente.");
                        }
                    }
                }

                if (!jogadaValida)
                {
                    Console.WriteLine("Jogada inválida. Tente novamente.");
                }

            } while (!jogadaValida);
        }

        static bool VerificarVitoria()
        {
            for (int linha = 0; linha < 3; linha++)
            {
                if (tabuleiro[linha, 0] != ' ' && tabuleiro[linha, 0] == tabuleiro[linha, 1] && tabuleiro[linha, 1] == tabuleiro[linha, 2])
                {
                    return true;
                }
            }

            for (int coluna = 0; coluna < 3; coluna++)
            {
                if (tabuleiro[0, coluna] != ' ' && tabuleiro[0, coluna] == tabuleiro[1, coluna] && tabuleiro[1, coluna] == tabuleiro[2, coluna])
                {
                    return true;
                }
            }

            if (tabuleiro[0, 0] != ' ' && tabuleiro[0, 0] == tabuleiro[1, 1] && tabuleiro[1, 1] == tabuleiro[2, 2])
            {
                return true;
            }

            if (tabuleiro[0, 2] != ' ' && tabuleiro[0, 2] == tabuleiro[1, 1] && tabuleiro[1, 1] == tabuleiro[2, 0])
            {
                return true;
            }

            return false;
        }
    }
}