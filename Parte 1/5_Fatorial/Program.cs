namespace _5_Fatorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe um número para calcular o fatorial: ");
            int numero = int.Parse(Console.ReadLine());

            int fatorial = 1;
            for(int i = 1; i <= numero; i++)
            {
                fatorial = fatorial * i;
            }
            Console.WriteLine("O fatorial de {0} é: {1}.", numero, fatorial);
        }
    }
}