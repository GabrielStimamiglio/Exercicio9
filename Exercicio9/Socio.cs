using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio9
{
    class Socio
    {
        private int idSocio;
        private double valorPago;

        public Socio(int idSocio)
        {
            this.idSocio = idSocio;
            valorPago = 0;
        }

        public int obterIdSocio()
        {
            return idSocio;
        }

        public void setIdSocio(int idSocio)
        {
            this.idSocio = idSocio;
        }

        public double obterValorPago()
        {
            return valorPago;
        }
    }
}
