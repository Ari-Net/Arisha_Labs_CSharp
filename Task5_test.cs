using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Arisha_HomeWork
{
    class Task5_test
    {
        [TestCase("Fred:Corwill;Wilfred:Corwill;Barney:Tornbull;Betty:Tornbull;Bjon:Tornbull;Raphael:Corwill;Alfred:Corwill", "(CORWILL, ALFRED)(CORWILL, FRED)(CORWILL, RAPHAEL)(CORWILL, WILFRED)(TORNBULL, BARNEY)(TORNBULL, BETTY)(TORNBULL, BJON)")]
        [TestCase("", "You are alone")]
        [TestCase("Johann:Bach", "(BACH, JOHANN)")]

        public void MeetingTest(string Input, string Output)
        {
            var res = Task5.Meeting(Input);
            Assert.AreEqual(res, Output);
        }
    }
}
