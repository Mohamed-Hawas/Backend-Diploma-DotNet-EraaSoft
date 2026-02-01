public class Program { 
    

    List<string> options = [
        "P. Print Numbers",
        "A. Add Number",
        "M. Calculate Mean",
        "S. Find Smallest Number",
        "L. Find Largest Number",
        "F. Find Number",
        "C. Clear Numbers",
        "O. Sort Numbers Ascending",
        "R. Sort Numbers Descending",
        "W. Swap Numbers",
        "U. Update Number",
        "D. Delete Number",
        "N. Get Numbers Count",
        "Q. Quit"
        ];
    char userOption;

    List<int> numbers = [ 8, 5, 3, 2, 0, 9];

    void Main(string[] args)
    {
        // The main code is here

        bool Flag = true;

        while (Flag)
        {
            printWindow();
            userOption = getUserOption();

            if (numbers.Count == 0 && userOption != 'A')
            {
                Console.WriteLine("List is empty");
                continue;
            }
            switch (userOption)
            {

                case 'P':
                    printNumbers();
                    break;
                case 'A':
                    Console.Write("Enter Numbers separated by space \" \": ");
                    string[] enteredNums = Console.ReadLine().Split(' ');

                    int[] nums = new int[enteredNums.Length];
                    for (int i = 0; i < enteredNums.Length; i++)
                    {
                        nums[i] = Convert.ToInt32(enteredNums[i]);
                    }
                    addNumber(nums, enteredNums.Length);
                    printNumbers();
                    break;
                case 'M':
                    double mean = calculateMean();
                    Console.WriteLine($"The mean is : {mean}");
                    break;
                case 'S':
                    int SmallestNumber = findSmallestNumber();
                    Console.WriteLine($"The smallest number is : {SmallestNumber}");
                    break;
                case 'L':
                    int LargestNumber = findLargestNumber();
                    Console.WriteLine($"The largest number is : {LargestNumber}");
                    break;
                case 'F':
                    Console.Write("Enter the number to find : ");
                    int target = Convert.ToInt32(Console.ReadLine());
                    bool found = findNumber(target);
                    if (found)
                        Console.WriteLine($"Found the number: {target}");
                    else
                        Console.WriteLine($"Number: {target} not found");

                    break;
                case 'C':
                    clearNumbers();
                    break;
                case 'O':
                    sortNumbersAscending();
                    printNumbers();
                    break;
                case 'R':
                    sortNumbersDescending();
                    printNumbers();
                    break;
                case 'W': // swap two num
                    Console.Write("Enter two numbers to swap separated by space : ");
                    string[] toSwap = Console.ReadLine().Split(' ');
                    swapNumbers(Convert.ToInt32(toSwap[0]), Convert.ToInt32(toSwap[1]));
                    printNumbers();
                    break;
                case 'U':
                    Console.Write("Enter the number to update : ");
                    int oldNum = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter the new number : ");
                    int newNum = Convert.ToInt32(Console.ReadLine());
                    updateNumber(oldNum, newNum);
                    printNumbers();
                    break;
                case 'D':
                    Console.Write("Enter the number to delete : ");
                    int delNum = Convert.ToInt32(Console.ReadLine());
                    deleteNumber(delNum);
                    printNumbers();
                    break;
                case 'N':
                    Console.WriteLine($"Numbers count is : {getNumbersCount()}");
                    break;
                case 'Q':
                    Flag = false;
                    break;
                default:
                    Console.WriteLine("Invalid Option!");
                    break;
            }
            Console.WriteLine("\n \n \n");
        }
    }
    void printWindow()
    {
        string space = "";
        int windowWidth = 40;
        int windowHeight = options.Count + 1;
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
                        Console.Write(options[i-1]);
                        j += options[i-1].Length - 1;
                    }
                    else
                        Console.Write(" ");

                }
            }

            Console.WriteLine();
        }
    }

    char getUserOption()
    {
        Console.Write("Enter your option : ");
        return userOption = Console.ReadLine().ToUpper()[0];
    }
    //"P. Print Numbers"
    void printNumbers()
    {
        Console.WriteLine("****************************************");
        Console.Write(    "==>>  Numbers : ");
        for(int i = 0; i < numbers.Count; i++)
        {
            Console.Write(numbers[i]);

            if(i < numbers.Count - 1)
                Console.Write(", ");
        }
        Console.WriteLine("\n****************************************");

    }

    //"A. Add Number"
    void addNumber(int [] nums, int count)
    {

        for(int i = 0; i < count; i++)
        {
            if (findNumber(nums[i])) // don't add if already exists
            {
                Console.WriteLine($"Number: {nums[i]} already exists");
                continue;
            }

            numbers.Add( nums[i] );
        }
    }

    //"M. Calculate Mean"
    double calculateMean()
    {
        int sum = 0 ;
        double avg ;
        for (int i = 0; i < numbers.Count; i++)
        {
            sum += numbers.ElementAt(i);
        
        }
        return avg = (double)sum / numbers.Count;
    }

    //"S. Find Smallest Number"
    int findSmallestNumber()
    {
        int smallest = numbers.ElementAt(0);
        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers.ElementAt(i) < smallest)
            {
                smallest = numbers.ElementAt(i);
            }
        }
        return smallest;
    }

    //"L. Find Largest Number"
    int findLargestNumber()
    {
        int largest = numbers.ElementAt(0);
        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers.ElementAt(i) > largest)
            {
                largest = numbers.ElementAt(i);
            }
        }
        return largest;
    }

    //"F. Find Number" 
    bool findNumber(int target)
    {
        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers.ElementAt(i) == target)
            {      
                return true;
            }
        }
        return false;
    }

    //"C. Clear Numbers"
    void clearNumbers()
    {
        numbers.Clear();
        Console.WriteLine("List successfully cleared");
    }
    //"O. Sort Numbers Ascending"
    void sortNumbersAscending()
    {   
        for (int i = 0; i < numbers.Count-1; i++)
        {
            if (numbers[i] > numbers[i + 1])
            { // swap
                int temp = numbers[i];
                numbers[i] = numbers[i + 1];
                numbers[i + 1] = temp;
                i = -1; // restart from beginning

            }
            
        }

    }
    //"R. Sort Numbers Descending"
    void sortNumbersDescending()
    {
        for (int i = 0; i < numbers.Count - 1; i++)
        {
            if (numbers[i] < numbers[i + 1])
            { // swap
                int temp = numbers[i];
                numbers[i] = numbers[i + 1];
                numbers[i + 1] = temp;
                i = -1; // restart from beginning

            }

        }

    }
    //"W. Swap Numbers"
    void swapNumbers(int num1, int num2)
    {
        int index1 = findIndexOfNumber(num1);
        int index2 = findIndexOfNumber(num2);
        if(index1 == -1 || index2 == -1)
            return;

        int temp = numbers[index1];
        numbers[index1] = numbers[index2];
        numbers[index2] = temp;
    }
    //"U. Update Number"
    void updateNumber(int oldNum, int newNum)
    {
        int index = findIndexOfNumber(oldNum);
        if (index == -1)
            return;
        numbers[index] = newNum;
    }
    //"D. Delete Number"
    void deleteNumber(int target)
    {
        int index = findIndexOfNumber(target);
        if(index == -1)
            return;
        numbers.RemoveAt(index);
    }
    //"N. Get Numbers Count"
    int getNumbersCount()
    {
        return numbers.Count;
    }


    int findIndexOfNumber(int target)
    {
        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers.ElementAt(i) == target)
            {
                return i;
            }
        }
        Console.WriteLine($"Number: {target} not found");
        return -1;
    }
}