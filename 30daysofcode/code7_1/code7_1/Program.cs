//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace code7_1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//        }
//    }
//}

using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{
   // int i = 0;


    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
     


       Array.Reverse(arr);
        //for(int i = 0;i < arr.Length;i++)
        var getTheNumbers = from number in arr
                            //where number < arr.GetLowerBound(0) && number > arr.GetUpperBound(0)
                            select number;
        //for (int i = arr.GetLowerBound(0); i <= arr.GetUpperBound(0); i++)
        //    {
        //        Console.WriteLine("{0}",arr.GetValue(i));
        //    }
        Console.WriteLine(string.Join(" ",getTheNumbers));
        Console.ReadKey();
    }
}
