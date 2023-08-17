namespace _6_RemovendoCidadesComS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cidades = new List<string>();
            bool continuar = true;

            Console.WriteLine("Digite 'parar' a qualquer momento para encerrar o programa.");
            do
            {
                Console.WriteLine("Informe uma cidade: ");
                string nome = Console.ReadLine();
                if (nome != "parar")
                {
                    cidades.Add(nome.ToUpper());
                }
                else
                {
                    continuar = false;
                }
            } while (continuar == true);

            for (int i = 0; i < cidades.Count; i++)
            {
                if (cidades[i].StartsWith('S'))
                {
                    cidades.RemoveAt(i);
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Lista atualizada sem as cidades que começam com 'S': ");
            foreach (string s in cidades)
            {
                Console.WriteLine(s);
            }
            
        }
    }
}