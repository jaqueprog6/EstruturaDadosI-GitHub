using System;

class Program
{
    static char[,] tabuleiro = new char[3, 3];
    static char jogadorAtual = 'X';

    static void Main()
    {
        InicializarTabuleiro();

        do
        {
            ExibirTabuleiro();
            FazerJogada();
        } while (!VerificarFimJogo());

        ExibirTabuleiro();
        Console.WriteLine("Fim do jogo!");
    }

    static void InicializarTabuleiro()
    {
        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 3; j++)
                tabuleiro[i, j] = ' ';
    }

    static void ExibirTabuleiro()
    {
        Console.Clear();
        Console.WriteLine("  0 1 2");
        for (int i = 0; i < 3; i++)
        {
            Console.Write(i + " ");
            for (int j = 0; j < 3; j++)
                Console.Write(tabuleiro[i, j] + " ");
            Console.WriteLine();
        }
    }

    static void FazerJogada()
    {
        int linha, coluna;

        do
        {
            Console.Write($"Jogador {jogadorAtual}, informe a linha (0-2): ");
        } while (!int.TryParse(Console.ReadLine(), out linha) || linha < 0 || linha > 2);

        do
        {
            Console.Write($"Jogador {jogadorAtual}, informe a coluna (0-2): ");
        } while (!int.TryParse(Console.ReadLine(), out coluna) || coluna < 0 || coluna > 2);

        if (tabuleiro[linha, coluna] == ' ')
        {
            tabuleiro[linha, coluna] = jogadorAtual;
            TrocarJogador();
        }
        else
        {
            Console.WriteLine("Essa posição já está ocupada. Tente novamente.");
            FazerJogada();
        }
    }

    static void TrocarJogador() => jogadorAtual = (jogadorAtual == 'X') ? 'O' : 'X';

    static bool VerificarFimJogo() => VerificarVitoria() || VerificarEmpate();

    static bool VerificarVitoria()
    {
        for (int i = 0; i < 3; i++)
            if (tabuleiro[i, 0] != ' ' && tabuleiro[i, 0] == tabuleiro[i, 1] && tabuleiro[i, 1] == tabuleiro[i, 2] ||
                tabuleiro[0, i] != ' ' && tabuleiro[0, i] == tabuleiro[1, i] && tabuleiro[1, i] == tabuleiro[2, i])
            {
                Console.WriteLine($"Jogador {tabuleiro[i, 0]} venceu!");
                return true;
            }

        if (tabuleiro[0, 0] != ' ' && tabuleiro[0, 0] == tabuleiro[1, 1] && tabuleiro[1, 1] == tabuleiro[2, 2] ||
            tabuleiro[0, 2] != ' ' && tabuleiro[0, 2] == tabuleiro[1, 1] && tabuleiro[1, 1] == tabuleiro[2, 0])
        {
            Console.WriteLine($"Jogador {tabuleiro[1, 1]} venceu!");
            return true;
        }

        return false;
    }

    static bool VerificarEmpate()
    {
        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 3; j++)
                if (tabuleiro[i, j] == ' ')
                    return false;

        Console.WriteLine("O jogo empatou!");
        return true;
    }
}
