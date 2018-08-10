using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithms
{
    class QuickSort
    {
        private int [] array;
        private int length;

        public int[] quicksortAsync(int[] inputArr)
        {

            if (inputArr == null || inputArr.Length == 0)
            { //checks to make sure the array has something
                return null;
            }
            this.array = inputArr;
            length = inputArr.Length;
            quickSort(0, length - 1);
            return inputArr;
        }

        private void quickSort(int lowerIndex, int higherIndex)
        {

            int i = lowerIndex;
            int j = higherIndex;
            // calculate pivot number, I am taking pivot as the last element in the array
            int pivot = array[lowerIndex + (higherIndex - lowerIndex)];
            // Divide into two arrays
            while (i <= j)
            {
                /**
	             * In each iteration, we will identify a number from left side which 
	             * is greater then the pivot value, and also we will identify a number 
	             * from right side which is less then the pivot value. Once the search 
	             * is done, then we exchange both numbers.
	             */
                while (array[i] < pivot)
                {
                    i++;
                }
                while (array[j] > pivot)
                {
                    j--;
                }
                if (i <= j)
                {
                    exchangeNumbers(i, j);
                    //move index to next position on both sides
                    i++;
                    j--;
                }
            }
            // call quickSort() method recursively
            if (lowerIndex < j)
                quickSort(lowerIndex, j);
            if (i < higherIndex)
                quickSort(i, higherIndex);
        }

        private void exchangeNumbers(int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
