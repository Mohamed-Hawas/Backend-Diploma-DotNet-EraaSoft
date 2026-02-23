using System;
using System.Collections.Generic;
using System.Text;

namespace Task_6_Exam_Management_System
{
    internal class TrueOrFalse : Question
    {
        public TrueOrFalse(string qTitle, QuestionType qType, int qMark, QuestionLevel qLevel, Choices qChoices)
            : base(qTitle, qType = QuestionType.TrueOrFalse, qMark, qLevel, qChoices)
        {

        }

        public TrueOrFalse()
        {
            QType = QuestionType.TrueOrFalse;
            QChoices[0] = "True";
            QChoices[1] = "False";
        }

        public bool QModelAnswer { get; set; }
        public bool QStudentAnswer { get; set; }

        //public override Choices QChoises;
        protected override string GetChoicesText()
        {
            string s = "";
            for (int i = 0; i < 2; i++)
            {
                s += $"{i + 1}. {QChoices[i]}.\n";
            }
            return s;
        }
        public override int GetResult()
        {
            if (QModelAnswer == QStudentAnswer)
                return QMark;

            return 0;
        }
    }
}
