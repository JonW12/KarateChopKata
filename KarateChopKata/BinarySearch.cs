using System;
using System.Collections.Generic;
using System.Text;

namespace KarateChopKata
{
    public class BinarySearch
    {
        public int Chop(int target, int[] arr)
        {
            int min = 0;
            int max = arr.Length;
            int index = (min + max) / 2;

            if (arr == null || arr.Length == 0)
            {
                return -1;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[index] == target)
                {
                    return index;
                }
                else if (arr[index] > target)
                {
                    max = index;
                }
                else if (arr[index] < target)
                {
                    min = index;
                }
                index = (min + max) / 2;
            }

            return -1;
        }
    }
}
