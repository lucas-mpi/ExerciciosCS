namespace _5_SomaMatriz 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos números deseja inserir?");
            int qntdNum = int.Parse(Console.ReadLine());

            int[] matriz = new int[qntdNum];

            int somaElementos = 0;

            for (int i = 0; i < qntdNum; i++)
            {
                Console.WriteLine("Informe o {0}º número: ", i+1);
                int num = int.Parse(Console.ReadLine());
                matriz[i] = num;

                somaElementos = somaElementos + num;
            }
            Console.WriteLine();
            Console.WriteLine("A soma de todos os elementos da matriz é = {0}.", somaElementos);
        }
    }
}