using System;
using Exercicio3.src.Entities;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, titulo;
            int qtdPaginas;

            Console.WriteLine("\nBem vindo a Livraria Amazon! A sua melhor escolha organizar seus livros!");
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("* Cadastro de leitor *");
            Console.WriteLine("Digite o nome: ");
            nome = Console.ReadLine(); 
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("Cadastro de Livro favorito");
            Console.WriteLine("Digite o titulo: ");
            titulo = Console.ReadLine();

            Console.WriteLine("Digite a quantidade de paginas: ");
            qtdPaginas = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------------------------------------");
            Livro livro = new Livro(titulo, qtdPaginas);
            Leitor leitor = new Leitor(nome, livro);

            Console.WriteLine("Inserir novo livro: \nDigite o titulo:");          
            titulo = Console.ReadLine();
            leitor.adicionarLivro(livro);

            Console.WriteLine("Digite a quantidade de paginas: ");
            qtdPaginas = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("Digite a quantidade de paginas lidas do livro favorito: ");
            int paginaLidas = int.Parse(Console.ReadLine());           
            for (int i = 0; i < paginaLidas; i++)
            {
                livro.adicionarpaginasLidas();
            } 
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine($"Progresso de leitura no livro Favorito: {livro.verificarProgresso():f0} %");
            Console.WriteLine("-------------------------------------------------------------");            
            Console.WriteLine($"Quantidade de livros na estante: {leitor.quantidadeLivrosEstante()}");
             Console.WriteLine("-------------------------------------------------------------");           
            leitor.removerLivro(livro);
            Console.WriteLine($"Quantidade de livros na estante: {leitor.quantidadeLivrosEstante()}");
            Console.ReadKey();
        }
    }
}
