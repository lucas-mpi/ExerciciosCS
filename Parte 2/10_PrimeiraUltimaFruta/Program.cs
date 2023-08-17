namespace _10_PrimeiraUltimaFruta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantas frutas deseja informar?");
            int qntdFrutas = int.Parse(Console.ReadLine());

            string[] frutas = new string[qntdFrutas];

            for (int i = 0; i < qntdFrutas; i++)
            {
                Console.WriteLine("Informe uma cor: ");
                string nomeFruta = Console.ReadLine();
                frutas[i] = nomeFruta;
            }

            string primeiraFruta = frutas[0];
            string ultimaFruta = frutas[qntdFrutas - 1];

            Console.WriteLine("A primeira fruta informada é: {0}", primeiraFruta);
            Console.WriteLine("A ultima fruta informada é: {0}", ultimaFruta);

        }
    }
}