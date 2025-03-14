namespace ProcoProdutoValid
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite Nome e preco do produto respectivamente: ");
            string[] Nome = new string[10];
            double[] preco = new double[10];

            for (int i = 0; i < 10; i++)
            {

                Console.Write("Digite o nome do produto " + (i + 1) + ": ");
                Nome[i] = Console.ReadLine();

                Console.Write("Digite o preco do produto " + (i + 1) + ": ");
                preco[i] = Convert.ToDouble(Console.ReadLine());
            }


            double ValorMax = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Produtos consultados pelo preco: ");

            for (int i = 0; i < 10; i++)
            {

                if (preco[i] <= ValorMax)
                {

                    Console.WriteLine("- " + Nome[i]);

                }
            }

            Console.ReadKey();
        }
    }
}
