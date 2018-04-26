using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio9
{
    class Ingresso
    {
        private double preco;
        private int codigo;
        private double valorPago;


        public Ingresso()
        {
            preco = 4;
            codigo = 0;
            valorPago = 0;
        }

        public void setValorPago(double valorPago)
        {
            this.valorPago = valorPago;
        }

        public void setPreco(double preco)
        {
            this.preco = preco;
        }

        public void setCodigo(int codigo)
        {
            this.codigo = codigo;
        }

        public double obterPreco()
        {
            return preco;
        }

        public int obterCodigo()
        {
            return codigo;
        }

        public double obterValorPago()
        {
            return valorPago;
        }
    }
}
