using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            string numero = Console.ReadLine();

            if(numero != ""){
                string[] inteiros = numero.Split(" ");
                int total = 0, n=0, maior=0;

                for(int i = 0; i < inteiros.Length; i++){
                    n = Convert.ToInt16(inteiros[i]);
                    total += n;
                    if(n > maior){
                        maior = n;
                    }
                }
                Console.WriteLine($"O maior número é {maior}");
                Console.WriteLine($"A soma dos valores é {total}");
            }
            else{
                    Console.WriteLine($"Digite um valor valido.");                
            }
        }
    }
}
