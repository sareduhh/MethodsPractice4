using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsPractice4
{
    class Program
    {
        static void Main(string[] args)
        { //Create a method to calculate the sum of the elements in an array. "Main" should look like this: 
        int[] example = { 20, 10, 5, 2 };
        Console.WriteLine("The sum of the example array is {0}", Sum(example));
        }
        static int Sum(int[] example)
        {
            return example.Sum();
        }
    }
}
