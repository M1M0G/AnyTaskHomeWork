using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TEST;
using AnyTaskQuickSort;

namespace AnyTaskQuickSort
{
    public class QuickSorting
    {

        public static void QuickSort(int[] a)
        {
            QuickSorter(a, 0, a.Length - 1);
        }

        public static void QuickSorter(int[] a, int l, int r)
        {
            int temp;
            int x = a[l + (r - l) / 2];
            int i = l;
            int j = r;
            while (i <= j)
            {
                while (a[i] < x) i++;
                while (a[j] > x) j--;
                if (i <= j)
                {
                    temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;
                    i++;
                    j--;
                }
            }
            if (i < r)
                QuickSorter(a, i, r);

            if (l < j)
                QuickSorter(a, l, j);
        }
    }
}
