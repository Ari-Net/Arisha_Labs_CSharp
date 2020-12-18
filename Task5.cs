using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Arisha_HomeWork
{
    class Task5
    {
        static public string Meeting(string s)
        {
            List<string> Friends = s.ToUpper().Split(";").ToList();
            List<List<string>> SurnameName = new List<List<string>>();
            string outp = "";
            int f = 1;
            for (int i = 0; i < Friends.Count(); i++){
                if (Friends[i].Contains(":")) { f = 2; SurnameName.Add(Friends[i].Split(":").Reverse().ToList()); }
            }
            var SortedUsers = SurnameName.OrderByDescending(u => u.First()).ThenByDescending(u => u.Last()).Reverse();
            foreach (List<string> item in SortedUsers){
                outp += "(" + item[0] + ", " + item[1] + ")";
            }
            if (f == 2) { return outp; }
            else return "You are alone";
        }

    }
}
