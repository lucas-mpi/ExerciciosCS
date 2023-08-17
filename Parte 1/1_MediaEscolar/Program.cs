using System.Globalization;

namespace _1_MediaEscolar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float media = 0;

            Console.WriteLine("Quantas disciplinas deseja inserir?");
            int qntdDisciplina = int.Parse(Console.ReadLine());

            float[] notas = new float[qntdDisciplina];


            for (int i = 0; i < qntdDisciplina; i++)
            {
                Console.WriteLine("Informe a nota da {0}ª disciplina ", i + 1);
                float notaDisciplina = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                notas[i] = notaDisciplina;

                media = media + notas[i];

            }

            media = media / qntdDisciplina;

            System.Console.WriteLine("A média do aluno é: {0}", media);

            Console.ReadKey();
        }
    }
}