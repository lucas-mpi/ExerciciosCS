namespace _2_ContagemRegressiva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe um número: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Contagem regressiva: ");
            for (int i = numero; i >= 0; i--)
            {
                Console.WriteLine("{0}", i);
            }

            Console.ReadKey();
        }
    }
}