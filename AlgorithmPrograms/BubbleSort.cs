using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class BubbleSort
    {
        public void Bubble_Sort()
        {
            int[] Arr = { 3, 1, 2 };
            int len = Arr.Length;

            Console.Write("Given Arr:");
            foreach (int data in Arr)
            {
                Console.Write("{0} ", data);

            }
            Console.WriteLine();


            int i, j, temp;
            for (i = 0; i < len; i++)
            {
                for (j = i + 1; j < len; j++)
                {
                    if (Arr[j] < Arr[i])
                    {
                        temp = Arr[i];
                        Arr[i] = Arr[j];
                        Arr[j] = temp;
                    }
                }
            }

            Console.Write("Sorted Arr:");
            foreach (int sortdata in Arr)
            {
                Console.Write("{0} ", sortdata);
            }
            Console.WriteLine();
        }
    }
}

