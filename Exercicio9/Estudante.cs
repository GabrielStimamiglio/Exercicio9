using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio9
{
    class Estudante
    {
        private int matricula;
        private double valorPago;

        public Estudante(int matricula)
        {
            this.matricula = matricula;
        }

        public int obterMatricula()
        {
            return matricula;
        }

        public double obterValorPago()
        {
            return valorPago;
        }

        public void setMatricula(int matricula)
        {
            this.matricula = matricula;
        }

        public void metadeDoPreco(double var)
        {
            valorPago = var / 2;
        }
    }
}
