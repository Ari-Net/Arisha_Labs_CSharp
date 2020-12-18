using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arisha_HomeWork
{
    class Task1_test
    {
        [TestCase(new object[] { 1, 2, "a", "b" }, new object[] { 1, 2 })]
        [TestCase(new object[] { 1, 2, "a", "b", 0, 15 }, new object[] { 1, 2, 0, 15 })]
        [TestCase(new object[] { 1, 2, "a", "b", "aasf", "1", "123", 231 }, new object[] { 1, 2, 231 })]
        [TestCase(new object[] {"0"," ", 1, 2, "a 1 ", "b", "aasf", "1", "123", 231 }, new object[] { 1, 2, 231 })]

        public void GetIntegerFromListTest(object[] InputList, object[] OutputList)
        {
            var res = Task1.GetIntegerFromList(InputList.ToList());
            Assert.AreEqual(res, OutputList.ToList());
        }
    }
}
