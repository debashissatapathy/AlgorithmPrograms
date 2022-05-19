using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class AnagramDetection
    {
        public bool AnagramDetector(string Word1, string Word2)
        {



            if (Word1.Length != Word2.Length)
            {
                Console.WriteLine("Please enter two strings of same length!");
                return false;
            }
            char[] array1 = Word1.ToLower().ToCharArray();
            char[] array2 = Word2.ToLower().ToCharArray();
            Array.Sort(array1);
            Array.Sort(array2);
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i])
                    return false;
            }
            return true;
        }
    }
}
