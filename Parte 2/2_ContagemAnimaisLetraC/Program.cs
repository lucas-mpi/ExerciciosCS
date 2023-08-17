namespace _2_ContagemAnimaisLetraC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Deseja informar quantos nomes?");
            int qntdNome = int.Parse(Console.ReadLine());

            string[] nomes = new string[qntdNome];

            int somaNomeComC = 0;

            
            for (int i = 0; i < qntdNome; i++)
            {
                Console.WriteLine("Informe o {0}º nome: ", i + 1);
                nomes[i] = Console.ReadLine();
                
                if (nomes[i].StartsWith("C") || nomes[i].StartsWith("c"))
                {
                    somaNomeComC++;
                }
                
            }

            Console.WriteLine();
            Console.WriteLine("Os nomes digitados foram:");
            
            foreach(string i in nomes)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            Console.WriteLine("Quantidade de animais na qual o nome começa com 'C': {0}.", somaNomeComC);
        }

    }
}