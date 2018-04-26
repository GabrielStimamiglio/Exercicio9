using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            int op;
            Ingresso i = new Ingresso();
            Bilheteria b = new Bilheteria();

            Console.WriteLine("Bem vindo ao Gabriel's cinema");
            Console.WriteLine("Gostaria de compara um ingresso? 1 - Sim 2 - Não");
            op = int.Parse(Console.ReadLine());

            if (op == 1)
            {
                Console.WriteLine("Valor do ingresso normal: ");
                Console.WriteLine(i.obterPreco().ToString("F2"));
                Console.WriteLine("Drscontos: ");
                Console.WriteLine("1 - Estudante(Paga meia)");
                Console.WriteLine("2 - Socio");
                Console.WriteLine("3 - Normal");
                int op2;
                op2 = int.Parse(Console.ReadLine());

                if (op2 == 1)
                {
                    int mat;

                    Console.WriteLine("Qual sua matricula?");
                    mat = int.Parse(Console.ReadLine());
                    Estudante e =new Estudante(mat);
                    b.venderIngresso(op2);
                    Console.WriteLine("");
                }else if (op2 == 2)
                {
                    int id;

                    Console.WriteLine("Qual seu ID?");
                    id = int.Parse(Console.ReadLine());
                    Socio s = new Socio(id);
                    b.venderIngresso(op2);
                    Console.WriteLine("");
                }
                else if (op2 == 3)
                {
                    b.venderIngresso(op2);
                    Console.WriteLine("");
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("Opção invalida");
                }

            }
            else
            {
                Console.WriteLine("Até mais!");
            }
            
            
        }
    }
}
