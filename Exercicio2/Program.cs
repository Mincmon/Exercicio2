using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Projeto
    {
        static void Main(string[] args){

            int svq = 27;


            if (svq <= 25) {

                float svp = (float)(svq * 1.5);

                Console.WriteLine("1- R$"+svp);

            } else
            {

                float svp = (float)(svq * 1.25);

                Console.WriteLine("1- R$" + svp);
            }

            int vn1 = 13;

            if (vn1 >= 10)
            {

                float cvn1 = (float)(vn1 + 10 * 2);

                Console.WriteLine("2- " + cvn1);

            }
            else
            {

                float cvn1 = (float)(vn1 + 9 * 3 - 8);

                Console.WriteLine("2- " + cvn1);
            }

            int vn2 = -14;

            if (vn1 >= 0)
            {

                Console.WriteLine("3- É positivo");

            }
            else
            {

                Console.WriteLine("3- É negativo");

            }

            int vn3 = 13;

            int vn4 = 7;

            if (vn3 > vn4){

                Console.WriteLine("4- O primeiro é maior");
            } else if (vn3 < vn4)
            {
                Console.WriteLine("4- O segundo é maior");
            }

            int vn5 = 9;

            int vn6 = 5;

            float m = (vn5 + vn6) / 2;
               
            Console.WriteLine("5- média = " +  m);

            if (m >= 7) {
                Console.WriteLine("Aprovado");
            } else
            {
                Console.WriteLine("Reprovado");
            }

        }
    }
}
