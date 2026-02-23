using System;
using System.Collections.Generic;
using System.Text;

namespace Task_6_Exam_Management_System
{
    internal class MCQ : Question
    {
        public MCQ(string qTitle, QuestionType qType, int qMark, QuestionLevel qLevel, Choices qChoices) 
            : base(qTitle, qType = QuestionType.MCQ, qMark, qLevel, qChoices )
        {
            
        }
        public MCQ() {
            QType = QuestionType.MCQ;
        }
        public int[] QModelAnswer = new int [2];
        public int[] QStudentAnswer = new int [2];
        public override int GetResult()
        {
            QModelAnswer.Sort();
            QStudentAnswer.Sort();
            if (QModelAnswer[0] == QStudentAnswer[0] && QModelAnswer[1] == QStudentAnswer[1])
                return QMark;

            return 0;
        }
    }
}
