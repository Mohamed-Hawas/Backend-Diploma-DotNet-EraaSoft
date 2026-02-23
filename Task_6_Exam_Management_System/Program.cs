// create main method
using System;
using Task_5_Student_Management_System;
using Task_6_Exam_Management_System;

class Program
{
    static void Main(string[] args)
    {
        Exam exam = new();

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
                    foreach (Question question in exam.Questions)
                    {
                        Console.WriteLine($"\nQuestion {n++}");
                        Console.WriteLine(question.ToString());
                        Console.Write("Answer : ");
                        string input = Console.ReadLine();
                        switch (question)
                        {
                            case TrueOrFalse tf:
                                if (bool.TryParse(input, out bool result))
                                {
                                    tf.QStudentAnswer = result;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid input");
                                }
                                break;
                            case ChooseOne co:
                                if (int.TryParse(input, out int choice))
                                {
                                    co.QStudentAnswer = choice;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid input");
                                }
                                break;
                            case MCQ mcq:
                                string[] arr = input.Split(' ');
                                mcq.QStudentAnswer = arr.Select(int.Parse).ToArray();
                                break;
                            default:
                                Console.WriteLine("Invalid Input !");
                                break;
                        }
                    }
                    Console.WriteLine("\n" + exam.GetResult());
                    break;

                case 2: // teacher mode
                        // put the questions of the exam
                    Console.Write("How many questions do you want to add in the exam ? : ");
                    int numberOfQuestions = int.Parse(Console.ReadLine());
                    for (int i = 1; i <= numberOfQuestions; i++)
                    {
                        Console.WriteLine($"\nEnter question {i} : "); // question num
                        Question? question = GetQuestion();
                        if (question != null)
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
        Question question;
        Console.Write("What is the type of question? \n 1. True/False \n 2. Choose one  \n 3. MCQ \n Enter your choice:(1, 2 or 3) : ");
        int type = int.Parse(Console.ReadLine());
        switch ((QuestionType)type)
        {
            case QuestionType.TrueOrFalse:
                question = new TrueOrFalse();
                return GetTrueFalseQuestion();
            case QuestionType.ChooseOne:
                question = new ChooseOne();
                return GetChooseOneQuestion();
            case QuestionType.MCQ:
                question = new MCQ();
                return GetMCQ();
            default:
                Console.WriteLine("Invalid Input !");
                return null;
        }   
    }

    private static string GetQuestionTitle()
    {
        Console.Write("Enter the question title : ");
        return Console.ReadLine();
    }

    private static int GetQuestionMark()
    {
        Console.Write("Enter the mark of the question : ");
        return int.Parse(Console.ReadLine());
    }

    private static QuestionLevel GetQuestionLevel()
    {
        while (true)
        {
            Console.Write("Enter the question level (easy, medium, hard) : ");
            string? qLevel = Console.ReadLine()?.ToLower();

            switch (qLevel)
            {
                case "easy":
                    return QuestionLevel.Easy;

                case "medium":
                    return QuestionLevel.Medium;

                case "hard":
                    return QuestionLevel.Hard;

                default:
                    Console.WriteLine("Wrong Input, try again.");
                    break;
            }
        }
    }


    private static MCQ GetMCQ()
    {
        MCQ question = new MCQ();

        question.QLevel = GetQuestionLevel();

        question.QMark = GetQuestionMark();

        question.QTitle = GetQuestionTitle();

        for (int i = 0; i < 4; i++)
        {
            Console.Write($"Enter choice {i + 1} : ");
            question.QChoices[i] = Console.ReadLine();
        }

        Console.Write("Enter the numbers of correct answer : ");
        string []input  = Console.ReadLine().Split(" ");

        for (int i = 0; i < input.Length; i++)
        {
            question.QModelAnswer[i] = int.Parse(input[i]);
        }

        return question;
    }

    private static ChooseOne GetChooseOneQuestion()
    {
        ChooseOne question = new ChooseOne();

        question.QLevel = GetQuestionLevel();

        question.QMark = GetQuestionMark();

        question.QTitle = GetQuestionTitle();

        for (int i = 0; i < 4; i++)
        {
            Console.Write($"Enter choice {i + 1} : ");
            question.QChoices[i] = Console.ReadLine();
        }

        Console.Write("Enter the number of correct answer : ");
        question.QModelAnswer = int.Parse(Console.ReadLine());

  
        return question;
    }

    private static TrueOrFalse GetTrueFalseQuestion()
    {
        TrueOrFalse question = new TrueOrFalse();

        question.QLevel = GetQuestionLevel();

        question.QMark = GetQuestionMark();

        question.QTitle = GetQuestionTitle();

        Console.Write("Enter the number of correct answer (True or False): ");
        string input = Console.ReadLine().ToLower();

        switch (input)
        {
            case "true":
                question.QModelAnswer = true;
                break;
            case "false":
                question.QModelAnswer = false;
                break;
            default:
                break;
        }

        return question;

    }
}