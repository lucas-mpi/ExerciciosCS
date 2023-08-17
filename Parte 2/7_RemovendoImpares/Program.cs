namespace _7_RemovendoImpares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numeros = new List<int>();
                
            bool parar = false;

            do
            {
                Console.WriteLine("Informe um número: ");
                int numero = int.Parse(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine("Deseja continuar? (S - Sim / N - Não)");
                Console.WriteLine();
                string verifica = Console.ReadLine().ToLower();
                if (verifica == "n")
                {
                    parar = true;
                }
                else
                {
                    numeros.Add(numero);
                }
            } while (parar != true);
            
            for (int i = 0; i < numeros.Count; i++)
            {
                if (numeros[i] < 0) 
                {
                    numeros.RemoveAt(i);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Lista atualizada sem os números negativos:");
            
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }
        }
    }
}