using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Arisha_HomeWork
{
    class Task4
    {
        static public int CountPairs(int[] InpArr, int Target){
            int counter = 0;
            for (int i = 0; i < InpArr.Length; i++){
                for (int k = i + 1; k < InpArr.Length; k++){
                    if ((InpArr[i] + InpArr[k] == Target) && (i != k)) { counter++; }
                }
            }
            return counter;
        }
    }
}
