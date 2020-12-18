using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Arisha_HomeWork
{
    class Task2
    {
        static public string First_non_repeating_letter(string Input){
           int count = 0;
           for (int i = 0; i < Input.Length; i++){
                for(int k = 0; k < Input.Length; k++){
                    if (Input.ToUpper()[i] == Input.ToUpper()[k]) { count++; }
                   
                }
                if (count == 1) { return Input[i].ToString(); }
                count = 0;
           }
           return "";
        }
    }
}
