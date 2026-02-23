
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


    internal abstract class Question
    {
        public string QTitle { get; set; }
        public QuestionType QType { get; set; }
        public int QMark { get; set; }
        public QuestionLevel QLevel { get; set; }

        public Choices QChoices { get; set; } = new Choices();  

        public Question(string qTitle, QuestionType qType, int qMark, QuestionLevel qLevel, Choices qChoices)
        {
            QTitle = qTitle;
            QType = qType;
            QMark = qMark;
            QLevel = qLevel;
            QChoices = qChoices;
        }

        public Question()
        {
        }
        protected virtual string GetChoicesText()
        {
            string s = "";
            for (int i = 0; i < 4; i++)
            {
                s += $"{i + 1}. {QChoices[i]}.\n";
            }
            return s;
        }
        public abstract int GetResult();
        
        public override string ToString() // print question
        {
            string s = "";
            s += $"QType : {QType.ToString()}   QMark : {QMark.ToString()}   QLevel : {QLevel.ToString()}\n";
            s += QTitle + "\n";
            s += GetChoicesText();
   
            return s;
        }
    }
}
