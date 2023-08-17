using System.Collections.Generic;
namespace _6_NumerosDigitados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numerosDigitados = new List<int>();
            int numero;

            Console.WriteLine("Informe quantos números quiser.");
            Console.WriteLine("Quando um número negativo for informado o programa encerrará.");
            Console.WriteLine();
            do
            {
                Console.WriteLine("Informe um número: ");
                numero = int.Parse (Console.ReadLine());
                if (numero > 0)
                {
                    numerosDigitados.Add(numero);
                }
                            
            }while(numero > 0);

            Console.WriteLine("Números positivos digitados: ");
            foreach (int i in numerosDigitados)
            {
                Console.Write("{0}, ", i);
            }
        }
    }
}