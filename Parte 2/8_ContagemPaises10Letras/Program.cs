namespace ContagemPaises10Letras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos países deseja inserir?");
            int qntdNomes = int.Parse(Console.ReadLine());

            string[] paises = new string[qntdNomes];

            int contaLetras = 0;
            for (int i = 0; i < qntdNomes; i++)
            {
                Console.WriteLine("Informe o {0}º país: ", i + 1);
                paises[i] = Console.ReadLine();

                if (paises[i].Length > 10)
                {
                    contaLetras++;
                }

            }

            Console.WriteLine("Dos países informados, {0} tem mais de 10 letras.", contaLetras);

        }
    }
}