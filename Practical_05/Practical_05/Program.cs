using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_05
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {1,2,3,4,5};


            for (int i = 0; i <= 5; i++)  // Intentionally going out of bounds
            {
                try
                {
                    Console.WriteLine($"Value at index {i}: {numbers[i]}");
                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine($"Exception caught: {ex.Message}");
                }
                finally
                {
                    Console.WriteLine("This is finally block");
                }
            }
            Console.ReadLine();
        }
    }
}
