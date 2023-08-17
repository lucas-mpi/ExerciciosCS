namespace _4_JogoAdivinhacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();


            int numeroRandon = random.Next(0, 10);
            bool acertou = false;
            do
            {
                Console.Write("Digite um número de 0 a 10: ");
                int numeroEscolhido = int.Parse(Console.ReadLine());

                if (numeroRandon == numeroEscolhido)
                {
                    Console.WriteLine("Parabéns, você adivinhou o número!");
                    acertou = true;
                }
                else
                {
                    Console.WriteLine("Não foi dessa vez, tente novamente! =/");
                    if (numeroEscolhido > numeroRandon)
                    {
                        Console.WriteLine("Dica: o número é menor...");
                    }
                    else
                    {
                        Console.WriteLine("Dica: o número é maior...");
                    }
                }

            } while (acertou == false);
        }
    }
}