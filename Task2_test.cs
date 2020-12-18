using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Arisha_HomeWork
{
    class Task2_test
    {
        [TestCase("sTreSS", "T")]
        [TestCase("", "")]
        [TestCase("ssaa", "")]
        [TestCase("ssa a", " ")]
        public void First_non_repeating_letter_Test(string Input, string Output)
        {
            var res = Task2.First_non_repeating_letter(Input);
            Assert.AreEqual(res, Output);
        }
    }
}
