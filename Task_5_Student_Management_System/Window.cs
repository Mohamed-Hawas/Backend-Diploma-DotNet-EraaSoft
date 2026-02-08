
namespace Task_5_Student_Management_System
{
    internal class Window(int windowWidth = 50)
    {
        List<string> options  = [];

        public int WindowWidth { get; set; } = windowWidth;

        public void Print()
        {
            string space = "";
            
            int windowHeight = options.Count + 2;
            int tab = 4; // 4 spaces

            char boarderSign = '*';
            for (int i = 0; i < windowHeight; i++)
            {
                Console.Write(space);
                // Draw top and bottom borders
                if (i == 0 || i == windowHeight - 1)
                {
                    for (int j = 0; j < windowWidth; j++)
                    {
                        Console.Write(boarderSign);
                    }
                }
                // Draw side borders and body
                else
                {
                    for (int j = 0; j < windowWidth; j++)
                    {
                        if (j == 0 || j == windowWidth - 1)
                            Console.Write(boarderSign);
                        else if (j == tab)
                        {
                            Console.Write(options[i - 1]);
                            j += options[i - 1].Length - 1;
                        }
                        else
                            Console.Write(" ");

                    }
                }

                Console.WriteLine();
            }
        }

        public int GetUserOption()
        {
            Console.Write("Enter your option : ");
            return int.Parse(Console.ReadLine());
        }

        public void SetOptions(List<string> options)
        {
            this.options = options;
        }

        public void SetOption(string option)
        {
            options.Add(option);
        }
    }
}
