using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithms
{
    class InsertionSort
    {
        public int[] insertionSortAsync(int[] array)
        {
            int j;                     // the number of items sorted so far
            int key;                // the item to be inserted
            int i;

            for (j = 1; j < array.Length; j++)    // Start with 1 (not 0)
            {
                key = array[j];
                for (i = j - 1; (i >= 0) && (array[i] > key); i--)   // Smaller values are moving up
                {
                    array[i + 1] = array[i];
                }
                array[i + 1] = key;    // Put the key in its proper location
            }

            return array;
        }
    }
}
