
namespace Task_6_Exam_Management_System
{
    enum QuestionType
    {
        TrueOrFalse = 1,
        ChooseOne = 2,
        MCQ = 3
    }

    enum QuestionLevel
    {
        Easy = 1,
        Medium= 2,
        Hard = 3
    }


    internal class Question
    {
        public string QTitle { get; set; }
        public QuestionType QType { get; set; }
        public int QMark { get; set; }
        public QuestionLevel QLevel { get; set; }

        public Choises QChoices { get; set; } = new();
        public string QModelAnswer { get; set; }

        public int QStudentAnswer { get; set; }

        public Question()
        {

        }
        public Question(string qTitle, QuestionType qType, int qMark, QuestionLevel qLevel, Choises qChoices, string qModelAnswer)
        {
            QTitle = qTitle;
            QType = qType;
            QMark = qMark;
            QLevel = qLevel;
            QChoices = qChoices;
            QModelAnswer = qModelAnswer;
        }

        public override string ToString() // print question
        {
            string s = "";
            s += $"QType : {QType.ToString()}   QMark : {QMark.ToString()}   QLevel : {QLevel.ToString()}\n";
            s += QTitle + "\n";
            int numberOfChoises = 4;
            if (QType == QuestionType.TrueOrFalse) numberOfChoises = 2;

            for (int i = 0; i < numberOfChoises; i++)
            {
                s += $"{i + 1}. {QChoices[i]}.\n";
            }

            return s;
        }
    }
}
