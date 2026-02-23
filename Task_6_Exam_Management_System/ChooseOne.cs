
namespace Task_6_Exam_Management_System
{
    internal class ChooseOne : Question 
    {
        public ChooseOne(string qTitle, QuestionType qType, int qMark, QuestionLevel qLevel, Choices qChoices)
            : base(qTitle, qType = QuestionType.ChooseOne, qMark, qLevel, qChoices)
        {

        }

        public int QModelAnswer { get; set; }
        public int QStudentAnswer { get; set; }


        public ChooseOne() {
            QType = QuestionType.ChooseOne;
        }

        public override int GetResult()
        {
            if (QModelAnswer == QStudentAnswer)
                return QMark;

            return 0;
        }
    }
}
