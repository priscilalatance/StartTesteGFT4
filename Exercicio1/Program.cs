using System;

namespace Exercicio1
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Ordem de Números e Números Invertidos. Adicione valores acima de Zero:");
            int numero = 15485448;
            char[] numeroOrdem = numero.ToString().ToCharArray();
            Array.Reverse(numeroOrdem);
            string numeroInvertido;
            Console.WriteLine($"{numero} --> {numeroInvertido = new string(numeroOrdem)}");


        }
    }
}
