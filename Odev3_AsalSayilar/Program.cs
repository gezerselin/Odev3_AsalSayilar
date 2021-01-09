using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev3_AsalSayilar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(2);
            for (int i = 3; i <10000; i=i+2)
            {
                bool asalMi = true;
                for (int j = 2; j < i; j++)
                {
                    if(i % j == 0)
                    {
                        asalMi = false;
                        break;
                    }
                }
                if (asalMi)
                {
                    Console.WriteLine(i);
                }
            }


            Console.ReadLine();
        }
    }
}
