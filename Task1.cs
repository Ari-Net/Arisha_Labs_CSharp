using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Arisha_HomeWork
{
    public class Task1
    {
        static public List<object> GetIntegerFromList(List<object> InputList)
        {
            List<object> res = new List<object>();
            foreach (object item in InputList)
            {
                if (item.GetType() == typeof(int)) {
                    res.Add(item);
                }
            }
            return res;
        }
    }
}
