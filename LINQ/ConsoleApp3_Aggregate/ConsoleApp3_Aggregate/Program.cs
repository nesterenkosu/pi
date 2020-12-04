using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3_Aggregate
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 7, 6, 2, 10 };

            int result = numbers.Aggregate((x,y)=>x+y);

            //int result = 1+7+6+2+10

            Console.WriteLine(numbers.Count());
            //Min,Max,Average ...

            Console.ReadLine();
        }
    }
}
