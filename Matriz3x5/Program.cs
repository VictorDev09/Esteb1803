namespace Matriz3x5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[3, 5];

            Console.WriteLine("Digite 15 números inteiros ");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"Elemento [{i},{j}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Soma dos valores de cada linha: ");

            for (int i = 0; i < 3; i++)
            {
                int somaLinha = 0;
                for (int j = 0; j < 5; j++)
                {
                    somaLinha += matriz[i, j];
                }
                Console.WriteLine($"Linha {i + 1}: {somaLinha}");
            }
        }
    }
}