//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace code2_1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//        }
//    }
//}
using System;
using System.Collections.Generic;
using System.IO;

class Solution
{
    static void Main(String[] args)
    {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";


        // Declare second integer, double, and String variables.
        int i1;
        double d1;
        string s1;
     

        // Read and save an integer, double, and String to your variables.
        Console.Write("Enter integer value: ");
       // s1 = Console.ReadLine();
        i1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter double value: ");
       // s1 = Console.ReadLine();
        d1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter string value: ");
        s1 = Console.ReadLine();



        // Print the sum of both integer variables on a new line.
        Console.WriteLine("{0}", i + i1);

        // Print the sum of the double variables on a new line.
         d1 = d + d1;
        // d1 = Math.Round(d1, 2);
         Console.WriteLine("{0:0.0}",d1);
        //string s2 = Convert.ToString(d + d1);
       // Console.WriteLine(s2);
        // Concatenate and print the String variables on a new line
        // The 's' variable above should be printed first.
        s = String.Concat(s, s1);
        
        Console.WriteLine("{0}", s);
        Console.ReadKey();
    }
}