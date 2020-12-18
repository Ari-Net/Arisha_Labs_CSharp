using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Arisha_HomeWork
{
    class Task3
    {
        static public int DigitalRoot(int InpNum)
        { 
            do{ InpNum = InpNum.ToString().ToCharArray().Sum(x => x - '0');} while (InpNum > 9);
            return InpNum;
        }
    }
}
