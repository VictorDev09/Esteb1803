namespace Nome10Alunos
{
    using System;

    public class Aluno
    {
        public string Nome { get; set; }
        public double[] Notas { get; set; }
        public double Media { get; set; }

        public Aluno(string nome, double[] notas)
        {
            Nome = nome;
            Notas = notas;
            Media = CalcularMedia(notas);
        }

        private double CalcularMedia(double[] notas)
        {
            double soma = 0;
            foreach (double nota in notas)
            {
                soma += nota;
            }
            return soma / notas.Length;
        }
    }

    public class Programa
    {
        public static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[10];

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Digite o nome do {i + 1}º aluno: ");
                string nome = Console.ReadLine();

                double[] notas = new double[3];
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Digite a {j + 1}ª nota do aluno {nome}: ");
                    notas[j] = double.Parse(Console.ReadLine());
                }

                alunos[i] = new Aluno(nome, notas);
            }

            Console.WriteLine("\nRelatório dos Alunos:");

            foreach (Aluno aluno in alunos)
            {
                if (aluno.Media >= 7.0)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"\nAluno: {aluno.Nome}");
                    Console.WriteLine($"Notas: {string.Join(", ", aluno.Notas)}");
                    Console.WriteLine($"Média: {aluno.Media:F2}");
                    Console.WriteLine("Situação: Aprovado");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\nAluno: {aluno.Nome}");
                    Console.WriteLine($"Notas: {string.Join(", ", aluno.Notas)}");
                    Console.WriteLine($"Média: {aluno.Media:F2}");
                    Console.WriteLine("Situação: Reprovado");
                }

                Console.ResetColor();
            }

            Console.ReadKey();
        }
    }
}