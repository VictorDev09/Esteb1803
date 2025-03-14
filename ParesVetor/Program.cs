namespace ParesVetor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] N = new int[15];

            for (int i = 0; i < N.Length; i++)
            {
                Console.Write("Digite 15 numeros: ");
                N[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Pares: ");
            for (int i = 0; i < N.Length; i += 2)
            {
                Console.WriteLine(N[i]);
            }
        }
    }
}
