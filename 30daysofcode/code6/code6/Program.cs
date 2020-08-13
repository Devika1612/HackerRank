using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code6
{
    class Program
    {
        //  public const int V = 1;

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
             string[] s = new string[n];

            for(int i=0;i<n;i++)
            { 
            s[i] = Console.ReadLine();
            }
            for (int j = 0; j < n; j++)
            {
                char[] charArr = s[j].ToCharArray();
                StringBuilder sb = new StringBuilder();
                for (int k = 0; k< charArr.Length; k++)
                {
                    if (k % 2 == 0)
                    {
                        sb.Append(charArr[k]);
                    }


                }
                sb.Append(" ");
                for (int p = 0; p< charArr.Length; p++)
                {
                    if (p % 2 == 1)
                    {
                        sb.Append(charArr[p]);
                    }


                }

                Console.WriteLine(sb);
                Console.ReadKey();
                sb.Clear();
            }
        }



        
    }
}
