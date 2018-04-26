using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio9
{
    class Bilheteria
    {
        int tipo;
        double precoAtual;
        double valorPagoF;
        

        List<Estudante>e = new List<Estudante>();
        List<Socio>s = new List<Socio>();
        List<Ingresso>i = new List<Ingresso>();
        List<Bilheteria> b = new List<Bilheteria>();

        Ingresso ingre = new Ingresso();

        public Bilheteria()
        {
            tipo = 0;
            precoAtual = 4;
            valorPagoF = 0;
        }
        public void adicionarEstudante(Estudante var)
        {
            e.Add(var);
        }

        public void adicionarSocio(Socio var)
        {
            s.Add(var);
        }

        public void adicionarIngressoN(Ingresso var)
        {
            i.Add(var);
        }

        public void adicionarBilhete(Bilheteria var)
        {
            b.Add(var);
        }
        public double getPrecoAtual()
        {
            return precoAtual;
        }

        public void venderIngresso(int var)
        {
            if(tipo == 1)
            {
                ingre.setCodigo(tipo);
                this.precoAtual = ingre.obterPreco() / 2;
                ingre.setValorPago(this.precoAtual);
                
            }else if(tipo == 2){

                ingre.setCodigo(tipo);
                this.precoAtual = ingre.obterPreco() - ingre.obterPreco();
                ingre.setValorPago(this.precoAtual);
            }
            else if(tipo == 3)
            {
                ingre.setCodigo(tipo);
                this.precoAtual = ingre.obterPreco();
                ingre.setValorPago(this.precoAtual);
            }
            else
            {
                Console.WriteLine("Erro!");
            }
            
        }


    }
}
