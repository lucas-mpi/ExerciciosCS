namespace _9_CoresPrimarias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantas cores deseja informar?");
            int qntdCores = int.Parse(Console.ReadLine());

            string[] cores = new string[qntdCores];

            int contaCores = 0;

            for (int i  = 0; i < qntdCores; i++)
            {
                Console.WriteLine("Informe uma cor: ");
                string cor = Console.ReadLine();

                cores[i] = cor.ToLower();

                if (cores[i] == "vermelho" || cores[i] == "amarelo" || cores[i] == "azul")
                {
                    contaCores++;
                }
            }

            Console.WriteLine();
            Console.WriteLine("{0} cor(es) informada(s) é(são) primária(s).", contaCores);
        }
    }
}