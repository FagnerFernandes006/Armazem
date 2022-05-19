using System;
using System.Globalization;

namespace Armazem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite os dados do primeiro produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Estoque: ");
            int estoque = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            Produto p = new Produto(nome, preco, estoque);
            Estoque e = new Estoque();
            e.ContabilizaEstoque(p.Preco, p.Estoque);

            double total = p.ValorTotalEmEstoque();
            
            Console.Write("Dados do produto : " + p);
            Console.WriteLine(" ");

            Console.WriteLine("Digite os dados do segundo Produto: ");
            Console.Write("Nome: ");
            nome = Console.ReadLine();
            Console.Write("Preço: ");
            preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Estoque: ");
            estoque = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine(" ");

            Produto p2 = new Produto(nome, preco, estoque);
            e.ContabilizaEstoque(p2.Preco, p2.Estoque);
            Console.Write("Dados do segundo produto : " + p2);
            Console.WriteLine(" ");

            Console.WriteLine("Dados:" + e);

        }
    }
}
