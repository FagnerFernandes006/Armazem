using System;
using System.Globalization;
using System.Text;

namespace Armazem
{
    class Estoque
    {
        public int estoque1;
        public double valor1;
        
        public Estoque()
        {
        }

        public void ContabilizaEstoque(double vlr, int q)
        {
            estoque1 += q;
            valor1 += (vlr * q);
        }

        public override string ToString()
        {
            return
                "Estoque Total: "
                + estoque1
                +", "
                + "Valor Total Em Estoque: "
                + " R$ "
                + valor1.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
