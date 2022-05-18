using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class PermutationString
    {
        internal static void permute(string str, int startindex, int endindex)
        {
            if (startindex == endindex)
            {
                Console.WriteLine(str);
            }
            else
            {
                for (int i = startindex; i <= endindex; i++)
                {
                    
                    str = swap(str, startindex, i);                    
                    permute(str, startindex + 1, endindex);                    
                    str = swap(str, startindex, i);
                }
            }
        }
        
        internal static string swap(string a, int i, int j)
        {
            char temp;
            char[] charArray = a.ToCharArray();
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            string s = new string(charArray);            
            return s;
        }
    }
}

