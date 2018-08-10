﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithms
{
    class HeapSort
    {
        public int heapSize;
        public int LEFT(int i)
        {
            //returns left index of a zero index based array
            return 2 * i + 1;
        }

        public int RIGHT(int i)
        {
            //returns right index of a zero based array
            return 2 * i + 2;
        }


        public void BUILD_MAX_HEAP(int[] A)
        {
            heapSize = A.Length;//heap size initialized
            for (int i = A.Length / 2; i >= 0; i--)//since n/2, n/2+1 ... are leaves we can start from n/2 step downwards
            {
                //call MAX_HEAPIFY on each root node starting from n/2
                MAX_HEAPIFY(A, i);
            }
        }


        public void MAX_HEAPIFY(int[] A, int i)
        {
            int l = LEFT(i);//the left element's index which is 2*i+1 (for zero based indexed array)
            int r = RIGHT(i);//right index = 2*i+2;
            int largestElementIndex = -1;//index can't be negative so initialize largest index , it will be used later
                                         //heapSize is the current size of the heap being worked upon
                                         //check if left index lies within the heap.
                                         //if element at left index is greater than root(A[i]) element, max heap property is violated
                                         //copy the index of violated element in largestElementIndex
            if (l < heapSize && A[l] > A[i])
            {
                largestElementIndex = l;
            }
            else //if max heap property is not violated copy the root's index in largestElementIndex
            {
                largestElementIndex = i;
            }
            //check to see the right sub tree for max heap property violation
            //here the largestElementIndex is calculated from previous step
            if (r < heapSize && A[r] > A[largestElementIndex])
            {
                largestElementIndex = r;
            }
            //if root doesn't has the largest index then swap the largest element with root element

            if (largestElementIndex != i)
            {
                int temp = A[i];
                A[i] = A[largestElementIndex];
                A[largestElementIndex] = temp;
                //after swap, recursively call the MAX_HEAPIFY on the largest index(root element)
                MAX_HEAPIFY(A, largestElementIndex);
            }
        }

        public int[] heapsortAsync(int[] A)
        {
            //max heap is built with heapSize initialized
            BUILD_MAX_HEAP(A);
            //starting from end loop through entire array
            for (int i = A.Length - 1; i >= 0; i--)
            {
                //since heap is already heapified and maintains max heap property
                //the first element of the array is root of max heap
                //swap it with the extreme element of the array i.e. setting the largest element to the end of array
                int temp = A[0];
                A[0] = A[i];
                A[i] = temp;
                //reduce the heap window by 1
                heapSize = heapSize - 1;
                //call max heapify on the reduced heap
                MAX_HEAPIFY(A, 0);
            }
            return A;
        }

    }
}
