using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K8U2_Primzahlen_dePaterMax
{
    class Program
    {
        static void Main(string[] args)
        {
            int zahl1;
            int zahl2;
            Zahl testzahl = new Zahl();

            Console.WriteLine("Geben sie ihren Testbereich ein: ");
            Console.WriteLine("von: ");
            zahl1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("bis: ");
            zahl2 = Convert.ToInt32(Console.ReadLine());

            for(int i = zahl1; i < zahl2; i++)
            {
                if (testzahl.IsPrime(i))
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();
        }
    }

    class Zahl
    {
        public bool IsPrime(int a)
        {
            bool Prime = false;
            
            for (int z = 2; z< a; z++)
            {
                if(a % z == 0)
                {
                    Prime = false;
                    z = a;
                }else
                {
                    Prime = true;
                }
            }
            return Prime;
        }
    }
}