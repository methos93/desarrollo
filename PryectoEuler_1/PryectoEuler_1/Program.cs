using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PryectoEuler_1
{
    class Program
    {
        static void Main(string[] args)
        {

            long s1 = 0;
            long s2 = 1;
            long fi = 0;
            long suma = 0;

            long t1 = 0;

            long t2 = 0;
            long pares = 0;
            int i = 0;
            while (fi <= 4000000)
            {
                suma = s1 + s2;
                fi = s2 + suma;
                s1 = suma;
                s2 = fi;

                if (suma % 2 == 0)
                {
                    t1 = t1 + suma;
                }

                if (fi % 2 == 0)
                {
                    t2 = t2 + fi;

                }
            }
            s1 = 0;
            s2 = 1;
            fi = 0;
            suma = 0;
            while (i <= 4000000)
            {


                suma = s1 + s2;
                fi = s2 + suma;
                s1 = suma;
                s2 = fi;
                i = i + 1;
            }


            pares = t1 + t2;


            Console.WriteLine(" la serie fibonacci tiene como resultado:" + s2);
            Console.WriteLine("La suma de los pares encontrados es:" + pares);


            Console.ReadLine();
        }
    }
}
