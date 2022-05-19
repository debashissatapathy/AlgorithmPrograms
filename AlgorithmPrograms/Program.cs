using System;

namespace AlgorithmPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            bool status = true;
            while (status)
            {
                Console.WriteLine("Algorithms Problems:\n1. Permutation of string\n2. Bubble Sort\n3. Insertion Sort\n4. Binary Search Word\n5. Merge Sort");
                int op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Console.WriteLine("********* Permutations of a String**********");
                        Console.WriteLine("Enter String");
                        var str = Console.ReadLine();
                        int n = str.Length;
                        PermutationString.permute(str, 0, n - 1);
                        break;
                    case 2:
                        Console.WriteLine("********* Bubble Sort**********");
                        BubbleSort b = new BubbleSort();
                        b.Bubble_Sort();
                        break;
                    case 3:
                        Console.WriteLine("********** Insertion Sort ************");
                        InsertionSort insert = new InsertionSort();
                        insert.Insertion_Sort();
                        break;
                    case 4:

                        BinarySearchWord bs = new BinarySearchWord();
                        string[] arr = { "apple", "ball", "cat", "dog", "egg", "fish" };
                        foreach (string s in arr)
                        {
                            Console.WriteLine(s);
                        }
                        Array.Sort(arr);
                        Console.WriteLine("Please enter a string to be searched :");
                        string key = Console.ReadLine();
                        int result = bs.Binary_Search_Word(arr, key);
                        if (result == -1)
                            Console.WriteLine("Element not present");
                        else
                            Console.WriteLine("Element found at "
                                            + "index " + result);
                        Console.WriteLine(result);
                        break;
                    case 5:
                        MergeSort merge = new MergeSort();
                        
                        int[] array = { 49, 3, 53, 21, 27, 75, 50, 41 };
                        Console.WriteLine("Merge Sort");
                        Console.Write("Initial array is: ");
                        for (int i = 0; i < 8; i++)
                        {
                            Console.Write(array[i] + " ");
                        }                       
                        merge.MergeSort1(array, 0,   7);
                        Console.Write("\nSorted Array is: ");
                        for (int i = 0; i < 8; i++)
                        {
                            Console.Write(array[i] + " ");
                        }
                        Console.WriteLine();
                        break;
                }
                Console.Write("\n");
            }

        }
    }
}
