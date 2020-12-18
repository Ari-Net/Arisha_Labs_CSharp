using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Arisha_HomeWork
{
    class Task4_test
    {
        [TestCase(new int[] { 1, 4, 2, 2, 3, 0, 5, 6 }, 3)]
        [TestCase(new int[] { }, 0)]
        [TestCase(new int[] { 1, 1, 2, 2, 7 }, 1)]
        [TestCase(new int[] { 1, 11, 2, 10, 3, 9, 4, 2, 0, 8 }, 5, 11)]

        public void CountPairsTest(int[] inp_array, int output, int Target = 4)
        {
            var res = Task4.CountPairs(inp_array, Target);
            Assert.AreEqual(res, output);
        }
    }
}
