using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Arisha_HomeWork
{
    class Task6
    {
        static void Swap(char[] ar, int i, int j){
            char temp = ar[i];
            ar[i] = ar[j];
            ar[j] = temp;
        }
        static public int NextBigger(int input){
            string res = "";
            int output = 0;
            char[] digits = input.ToString().ToCharArray();
            int n = digits.Length;
            int i;
            for (i = n - 1; i > 0; i--)
            {
                if (digits[i] > digits[i - 1]) { break; }
            }
            if (i == 0) { return -1; }
            else
            {
                int x = digits[i - 1], min = i;
                for (int j = i + 1; j < n; j++){
                    if (digits[j] > x && digits[j] < digits[min]) { min = j; }
                }
                Swap(digits, i - 1, min);
                Array.Sort(digits, i, n - i);
                
                for (i = 0; i < n; i++)
                {
                    res += digits[i];
                }
                output = Convert.ToInt32(res);
            }
            return output;
        }

    }
}
