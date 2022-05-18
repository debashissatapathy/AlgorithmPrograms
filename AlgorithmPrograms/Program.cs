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
                Console.WriteLine("Algorithms Problems:\n1)Permutation of string\n2)Bubble Sort\n");
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
                    //case 2:
                    //    Console.WriteLine("********* Bubble Sort**********");
                    //    BubbleSort b = new BubbleSort();
                    //    b.BSort();
                    //    break;

                }
            }

        }
    }
}
