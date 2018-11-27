using System;
using System.Collections.Generic;
using System.Text;

namespace DilemmaDelPrigioniero
{
    public static class Extensions
    {
        public static void BubbleSortComparable<T>(IList<T> myList) 
             where T : IComparable<T>
        {
            for (int i = myList.Count - 1; i > 0; i--)
            {

                for (int j = 0; j < i; j++)
                {
                    //  if (myList[j] > myList[j + 1])
                    int res = myList[j].CompareTo(myList[j + 1]);
                    if (res > 0)
                    {
                        Swap(myList, j, j + 1);
                    }
                }
            }
        }
        private static void Swap<T>(IList<T> a, int j, int v)
        {
            var temp = a[j];
            a[j] = a[v];
            a[v] = temp;
        }
    }
}
