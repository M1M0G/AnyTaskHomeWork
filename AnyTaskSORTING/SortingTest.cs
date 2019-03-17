using NUnit.Framework;
using TEST;
using NUnit.Compatibility;
using System;
using AnyTaskQuickSort;

namespace TEST
{

    [TestFixture]
    public class SortingTest
    {
        [Test]
        public void TestMassiveEmptyEl()
        {
            var array = new int[10];
            for (var i = 0; i < array.Length; i++)
            {
                array[i] = ' ';
            }
            QuickSorting.QuickSort(array);
            Assert.AreEqual(array, array);
        }

        [Test]
        public void TestMassiveThreeEl()
        {
            var array = new int[] { 3, 2, 1 };
            QuickSorting.QuickSort(array);
            Assert.IsTrue(array[0] < array[1]);
            Assert.IsTrue(array[1] < array[2]);
        }

        [Test]
        public void TestMassiveOneHundredEl()
        {
            var array = new int[100];
            int i = 0;
            while (i < array.Length - 1)
            {
                array[i] = 3;
                i++;
            }
            QuickSorting.QuickSort(array);
            Assert.AreEqual(array, array);
        }

        [Test]
        public void TestMassiveOneThousandEl()
        {
            var rnd = new Random(42);
            var array = new int[1000];
            for (var i = 0; i < array.Length; i++)
                array[i] = rnd.Next(-100, 100);
            QuickSorting.QuickSort(array);
            for (var i = 0; i < 10; i++)
            {
                var x = rnd.Next(0, array.Length - 2);
                var y = rnd.Next(0, array.Length - 1);
                if (x >= y)
                    Assert.GreaterOrEqual(array[x], array[y]);
                else
                    Assert.GreaterOrEqual(array[y], array[x]);
            }
        }



        [Test]
        public void TestMassiveOverNineThousandEl()
        {
            var rnd = new Random(42);
            var array = new int[300000000];
            for (var i = 0; i < array.Length; i++)
                array[i] = rnd.Next(int.MinValue, int.MaxValue);
            QuickSorting.QuickSort(array);
        }
    }
}
