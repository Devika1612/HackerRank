using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code5
{
    class Program
    {
     public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
          //  int s;
            for (int i=1; i<=10; i++)
            {
               // s = n * i;
                Console.WriteLine("{0}x{1}={2}",n,i,n*i);
            }
            Console.ReadKey();
        }
    }
}
