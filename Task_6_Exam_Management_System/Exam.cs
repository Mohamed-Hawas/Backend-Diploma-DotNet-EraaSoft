using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.Java;
using System.Text;

namespace Task_6_Exam_Management_System
{
    internal class Exam
    {
        public List<Question> Questions { get; set; } = [];
        public string GetResult()
        {
            int marks = 0, totalMarks = 0 ;
            foreach (var question in Questions)
            {
                totalMarks += question.QMark;
                marks += question.GetResult();
            }
            return $"Result : {marks} / {totalMarks} ";
        }

    }
}
