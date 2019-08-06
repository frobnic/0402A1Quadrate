using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0402A1Quadrate
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            // for-schleife
            for (i = 1; i <= 10; i++)
                Console.WriteLine("Das Quadrat von {0,2} ist {1,3}", i, i * i);

            // while-schleife
            i = 1;
            while (i <= 10)
            {
                Console.WriteLine("Das Quadrat von {0,2} ist {1,3}", i, i * i);
                i++;
            }

            // do while-schleife
            i = 1;
            do
            {
                Console.WriteLine("Das Quadrat von {0,2} ist {1,3}", i, i * i);
                i++;
            } while (i <= 10);

        }
    }
}
