namespace _1_ContagemNumerosPares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos números deseja adicionar? ");
            Console.WriteLine();
            int tamanhoMatriz = int.Parse(Console.ReadLine());

            int[] matriz = new int[tamanhoMatriz];

            int contaPar = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Informe o {0}º número: ", i+1);
                int num = int.Parse(Console.ReadLine());
                matriz[i] = num;
                Console.WriteLine();

                if (num % 2  == 0)
                {
                    contaPar = contaPar + 1; 
                }
            }
            Console.Write("Números inseridos na matriz: ");
            foreach (int i in matriz)
            {
                Console.Write("{0}, ", i);

            }
            Console.WriteLine();
            Console.Write("Foram inseridos {0} números pares.", contaPar);
        }
    }
}