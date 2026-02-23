using System;
using System.Collections.Generic;
using System.Text;

namespace Task_6_Exam_Management_System
{
    internal class Choices
    {
        private string[] choices = new string[4];
        public string this[int i]
        {
            get { 
                return this.choices[i]; 
            }
            set { 
                choices[i] = value;  
            }
        }
    }
}
