using System;
using ExercicioPOO4.src.entities;

namespace ExercicioPOO4
{
    class Program
    {
        static void Main(string[] args)
        {
            Gerente gerente = new Gerente("Priscila", 25 , 2500);
            Supervisor supervisor = new Supervisor("Rafel", 28 , 1500);
            Vendedor vendedor = new Vendedor("Junior", 35, 1000);

            Console.WriteLine("\n                     *Dados de Pagamentos de Funcionários *");
            Console.WriteLine($"Funcionaria {gerente.Nome}, idade {gerente.Idade}, salario: {(gerente.Salario):C2} e bonificação {gerente.bonificacao(gerente.Salario):C2}");
            Console.WriteLine("-------------------------------------------------------------------------------------");            
            Console.WriteLine($"Funcionario {supervisor.Nome}, idade {supervisor.Idade}, salario: {(supervisor.Salario):C2} e bonificação {supervisor.bonificacao(supervisor.Salario):C2}");
            Console.WriteLine("-------------------------------------------------------------------------------------");     
            Console.WriteLine($"Funcionario {vendedor.Nome}, idade {vendedor.Idade}, salario: {(vendedor.Salario):C2} e bonificação {vendedor.bonificacao(vendedor.Salario):C2}"); 
            Console.WriteLine("-------------------------------------------------------------------------------------");       
        }
    }
}
