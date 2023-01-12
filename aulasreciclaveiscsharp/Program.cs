using System;

namespace aulasreciclaveiscsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();

            Console.WriteLine(produto);

            Console.WriteLine("Entre com os dados do produto");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine());
           
            produto.Nome = nome;
            produto.Preco = preco;

            Console.WriteLine(produto);

            Console.Write("Digite o total de produtos a serem adicionados ao estoque: ");

            int qte = int.Parse(Console.ReadLine());
            produto.AdicionarProdutos(qte);
            Console.WriteLine(produto);

            Console.Write("Digite o total de produtos a serem removidos do estoque: ");

            qte = int.Parse(Console.ReadLine());
            produto.RemoverProdutos(qte);
            Console.WriteLine(produto);
        }
    }
}
