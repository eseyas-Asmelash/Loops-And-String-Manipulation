namespace Loops;

class Program
{
    static void Main(string[] args)
    {
        
        bool continueProgram = true;
        // Create infinite While loop for the main menu
        //Exit main menu by clicking 0
        while (continueProgram)
        {
            
            Console.WriteLine("Welcome to the Main menu");
            Console.WriteLine("Choose from the alternative below:");
            Console.WriteLine("1. Check age (Teneeger or Senior)");
            Console.WriteLine("2. Calculate the total price of a group");
            Console.WriteLine("3. Repeat a word 10 times");
            Console.WriteLine("4. Get the third word in a sentence");
            Console.WriteLine("0. Exit program");

            var choice = Console.ReadLine();

            //Switch case to choose from the option elencated in the main menu
            switch (choice)
            {
                case "0":
                    continueProgram = false;
                    break;
                case "1":
                    YouthOrSenior();
                    break;
                case "2":
                    GroupPrice();
                    break;
                case "3":
                    RepeatTextTenTimes();
                    break;
                case "4":
                    ThirdWord();
                    break;
                default:
                    Console.WriteLine("Wrong input, please try again.");
                    break;
            }
        }
    }
    /// <summary>
    ///     Youth or Senior Method that take an input (age)
    ///     and checks if the person is a teneeger or a senior
    ///     and write the appropriate price for the ticket to the console
    /// </summary>
    static void YouthOrSenior()
    {
        Console.WriteLine("Write your Age:");
        string input = Console.ReadLine()!;

        if (int.TryParse(input, out int age))
        {
            if (age < 20)
            {
                Console.WriteLine("Teneeger price: 80kr");
            }
            else if (age > 64)
            {
                Console.WriteLine("Senior price: 90kr");
            }
            else
            {
                Console.WriteLine("Standard Price: 120kr");
            }
        }
        else
        {
            Console.WriteLine("Wrong input, please try again.");
        }
    }
    /// <summary>
    ///  GroupPrice method take as in input the amount of people in
    ///  the group and calculate the total price according to thier 
    ///  age
    /// </summary>
    static void GroupPrice()
    {
        Console.WriteLine("How many people are in the group");
        var input = Console.ReadLine();

        if (int.TryParse(input, out int numberOfPeople))
        {
            int totalPrice = 0;
            for (int i = 0; i < numberOfPeople; i++)
            {
                Console.WriteLine($"Enter age of person {i + 1}:");
                var ageInput = Console.ReadLine();

                if (int.TryParse(ageInput, out int age))
                {
                    if (age < 5 || age > 100)
                    {
                        Console.WriteLine("Free entry");
                    }
                    else if (age < 20)
                    {
                        Console.WriteLine("Tenageer price: 80kr");
                        totalPrice += 80;
                    }
                    else if (age > 64)
                    {
                        Console.WriteLine("Senior price: 90kr");
                        totalPrice += 90;
                    }
                    else
                    {
                        Console.WriteLine("Standard price: 120kr");
                        totalPrice += 120;
                    }
                }
                else
                {
                    Console.WriteLine("Wrong input, please try again.");
                    i--;
                }
            }
            Console.WriteLine($"Total number of persons in the group: {numberOfPeople}");
            Console.WriteLine($"The total cost of the group: {totalPrice}kr");
        }
        else
        {
            Console.WriteLine("Wrong input, please try again.");
        }
    }
    /// <summary>
    /// Repeats an input ten times in a row by using a for loop
    /// </summary>
    static void RepeatTextTenTimes()
    {
        Console.WriteLine("Write a text:");
        var input = Console.ReadLine();

        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"{i}. {input} ");
        }
        Console.WriteLine();
    }
    /// <summary>
    /// takes a sentence as in input the writes the third word to the console
    /// 
    /// </summary>
    static void ThirdWord()
    {
        Console.WriteLine("Write a sentence containing at least 3 words");
        string input = Console.ReadLine()!;
        string[] words = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        if (words.Length >= 3)
        {
            Console.WriteLine($"the third word is: {words[2]}");
        }
        else
        {
            Console.WriteLine("You did not enter a sentence containing 3 or more words .");
        }
    }
}
