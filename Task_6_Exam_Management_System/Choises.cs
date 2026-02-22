using System;
using System.Collections.Generic;
using System.Text;

namespace Task_6_Exam_Management_System
{
    internal class Choises
    {
        private string[] choise = ["True","False","",""];
        public string this[int i]
        {
            get { 
                return this.choise[i]; 
            }
            set { 
                choise[i] = value;  
            }
        }

        //public override string ToString()
        //{
        //    string s = "";
        //    for (int i = 0; i < 4; i++)
        //    {
        //        s += $"{i+1}. {choise[i]}.\n";
        //    }
        //    return s;
        //}
    }
}
