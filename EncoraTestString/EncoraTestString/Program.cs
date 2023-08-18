using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncoraTestString
{
   public class Program
    {
        public static void Main(string[] args)
        {
            StringTest test = new StringTest();
            Console.WriteLine("Write the list of string in each case"); 
            Console.WriteLine("");
            Console.WriteLine("Write Test Case 1");            
            Console.WriteLine(test.SortStringByCharFrequencyTest1(Console.ReadLine().Split()));
            Console.WriteLine("");
            Console.WriteLine("Write Test Case 2");
            Console.WriteLine(test.SortStringByCharFrequencyTest2(Console.ReadLine().Split()));
            Console.WriteLine("");
            Console.WriteLine("Write Test Case 3");
            Console.WriteLine(test.SortStringByCharFrequencyTest3(Console.ReadLine().Split()));
            Console.WriteLine("");
            Console.WriteLine("Write Test Case 4");
            Console.WriteLine(test.SortStringByCharFrequencyTest4(Console.ReadLine().Split()));
            Console.WriteLine("");
            Console.WriteLine("Write Test Case 5");
            Console.WriteLine(test.SortStringByCharFrequencyTest5(Console.ReadLine().Split()));
            Console.WriteLine("");
            Console.WriteLine("Finish all the test");
        }
    }
}
