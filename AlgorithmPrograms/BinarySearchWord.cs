using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class BinarySearchWord
    {
        public int Binary_Search_Word(string[] arr, string key)
        {
            int left = 0, right = (arr.Length - 1);

            while (left <= right)
            {
                int mid = Math.Abs((left + right) / 2);
                if (arr[mid] == key)
                    return mid;
                else if (key.CompareTo(arr[mid]) > 0)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            return -1;
        }
    }
}
