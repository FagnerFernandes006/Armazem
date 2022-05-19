using System;
using System.Globalization;
using System.Text;

namespace Armazem
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Estoque;

        public Produto(string nome, double preco, int estoque)
        {
            Nome = nome;
            Preco = preco;
            Estoque = estoque;
        }
        public double ValorTotalEmEstoque()
        {
            return Preco * Estoque;
        }
        public override string ToString()
        {
            return Nome 
                + ", R$ " +
                Preco.ToString("F2", CultureInfo.InvariantCulture) 
                + ", " 
                + Estoque 
                + " Unidade, Total: R$ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
