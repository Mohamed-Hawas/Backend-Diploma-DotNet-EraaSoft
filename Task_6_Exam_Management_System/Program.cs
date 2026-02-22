// create main method
using System;
using Task_5_Student_Management_System;
using Task_6_Exam_Management_System;

class Program
{
    static void Main(string[] args)
    {
        Exam exam = new();
        Question question = new Question();
        List<string> mainMenu = [
            "1. Student Mode",
            "2. Teacher Mode",
            "3. Quit"
        ];

        
        while (true)
        {
            Window.Print(mainMenu);
            int option = Window.GetUserOption();
            switch (option)
            {
                case 1: // student mode
                        // start exam
                    Console.WriteLine("\n========= Start Exam =========");
                    int n = 1;
                    foreach (Question q in exam.Questions)
                    {
                        Console.WriteLine($"\nQuestion {n++}");
                        Console.WriteLine(q.ToString());
                        Console.Write("Answer : ");
                        q.QStudentAnswer = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine(exam.GetResult());
                    break;

                case 2: // teacher mode
                        // put the questions of the exam
                    Console.Write("How many questions do you want to add in the exam ? : ");
                    int numberOfQuestions = int.Parse(Console.ReadLine());
                    for (int i = 1; i <= numberOfQuestions; i++)
                    {
                        Console.WriteLine($"Enter question {i} : "); // question num
                        question = GetQuestion();
                        exam.Questions.Add(question);
                    }
                    break;

                case 3:
                    return;

            }
        }
    }

    public static Question? GetQuestion()
    {
        Question question = new Question();
        Console.Write("What is the type of question? \n 1. True/False \n 2. Choose one  \n 3. MCQ \n Enter your choice:(1, 2 or 3) : ");
        int type = int.Parse(Console.ReadLine());
        question.QType = (QuestionType)type;

        Console.Write("Enter the question level (easy, medium, hard) : ");
        string qLevel = Console.ReadLine().ToLower();
        switch (qLevel)
        {
            case "easy":
                question.QLevel = QuestionLevel.Easy;
                break;
            case "medium":
                question.QLevel = QuestionLevel.Medium;
                break;
            case "hard":
                question.QLevel = QuestionLevel.Hard;
                break;
            default:
                Console.WriteLine("Wrong Input");
                return null;
        }
        Console.Write("Enter the mark of the question : ");
        question.QMark = int.Parse(Console.ReadLine());

        Console.Write("Enter the question title : ");
        question.QTitle = Console.ReadLine();


        if(question.QType == QuestionType.ChooseOne || question.QType == QuestionType.MCQ)
        {
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"Enter choice {i+1} : ");
                question.QChoices[i] = Console.ReadLine();
            }

            Console.Write("Enter the number of correct answer : ");
            int ans = int.Parse(Console.ReadLine());
            question.QModelAnswer = question.QChoices[ans-1];
        }
        else
        {
            Console.Write("Enter the correct answer (True or False): ");
            question.QModelAnswer = Console.ReadLine();
        }
        return question;
    }

}