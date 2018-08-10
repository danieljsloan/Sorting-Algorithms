using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithms
{
    public class Print
    {
       public void print(int[] input)
        {

            for (int i = 0; i < input.Length; i++)
            {
                System.Console.Write(input[i] + ", "); //prints the array
            }
            System.Console.WriteLine("\n");
        }
    }
}
