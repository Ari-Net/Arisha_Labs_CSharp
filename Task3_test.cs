using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Arisha_HomeWork
{
    class Task3_test
    {
        [TestCase(1, 1)]
        [TestCase(12, 3)]
        [TestCase(548, 8)]
        [TestCase(2718291, 3)]

        public void DigitalRootTest(int input, int output)
        {
            var InpNum = Task3.DigitalRoot(input);
            Assert.AreEqual(InpNum, output);
        }
    }
}
