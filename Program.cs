using System;

namespace Maior2Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            double numeroUm, numeroDois;
            string textoNumeroUm, textoNumeroDois;
            bool numeroUmValido, numeroDoisValido;

            Console.Clear();
            Console.WriteLine("--- Maior de dois números");

            Console.Write("Digite o primeiro número..: ");
            textoNumeroUm = Console.ReadLine();
            Console.Write("Digite o segundo número...: ");
            textoNumeroDois = Console.ReadLine();

            numeroUmValido = double.TryParse(textoNumeroUm, out numeroUm);
            numeroDoisValido = double.TryParse(textoNumeroDois, out numeroDois);

            if (!numeroUmValido)
            {
               Console.WriteLine("Valor inválido");
               Environment.Exit(-1);
            }
            else if (!numeroDoisValido)
            {
               Console.WriteLine("Valor inválido");
               Environment.Exit(-1);
            }
            else if (numeroUm > numeroDois)
            {
                Console.WriteLine($"O maior número é {numeroUm}");
            }
            else
            {
                Console.WriteLine($"O maior número é {numeroDois}");
            }
            
        }
    }
}
