using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Arisha_HomeWork
{
    class Task6_test
    {
        [TestCase(12, 21)]
        [TestCase(438829893, 438829938)]
        [TestCase(6, -1)]
        [TestCase(111, -1)]
        [TestCase(632, -1)]

        public void NextBiggerTest(int Input, int Output)
        {
            var res = Task6.NextBigger(Input);
            Assert.AreEqual(res, Output);
        }
    }
}
