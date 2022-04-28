Console.WriteLine("Welcome to the Number Grades to Letter Grades Application!");
CleanScreen();

bool runningNumbers = true;
while (runningNumbers)
{
    Console.WriteLine("Enter the number you wish to convert to a letter grade: ");
    Console.Write("Your Number: ");
    string userEntry = Console.ReadLine();
    bool isANumber = int.TryParse(userEntry, out int userNumber);
    if (isANumber)
    {
        Console.WriteLine("");
        Console.WriteLine(ReturnLetterGrade(userNumber));
        Console.WriteLine("");
        runningNumbers = WannaRestart();
    }
    else
    {
        Console.WriteLine("");
        Console.WriteLine("I'm sorry, that doesn't appear to be a number. Let's try again.");
        CleanScreen();

    }
}
Console.WriteLine("Thank you for using the Number Grades to Letter grades Coverter Application!");
Console.WriteLine("Goodbye...");
static void CleanScreen()
{
    Console.WriteLine("");
    Console.WriteLine("Press Enter to Continue.");
    Console.ReadLine();
    Console.Clear();
}
static string ReturnLetterGrade(int userNumber)
{
    if (userNumber >= 99)
    {
        return "You got an A+!";
    }
    else if (userNumber >=93 && userNumber <= 98)
    {
        return "You got an A!";
    }
    else if (userNumber >= 90 && userNumber <= 92)
    {
        return "You got an A-!";
    }
    else if (userNumber >= 88 && userNumber <= 89)
    {
        return "You got a B+!";
    }
    else if (userNumber >= 83 && userNumber <= 87)
    {
        return "You got a B!";
    }
    else if (userNumber >= 80 && userNumber <= 82)
    {
        return "You got a B-!";
    }
    else if (userNumber >= 78 && userNumber <= 79)
    {
        return "You got a C+.";
    }
    else if (userNumber >= 73 && userNumber <= 77)
    {
        return "You got a C.";
    }
    else if (userNumber >= 70 && userNumber <= 72)
    {
        return "You got a C-.";
    }
    else if (userNumber >= 68 && userNumber <= 69)
    {
        return "You got a D+.";
    }
    else if (userNumber >= 63 && userNumber <= 67)
    {
        return "You got a D.";
    }
    else if (userNumber >= 60 && userNumber <= 62)
    {
        return "You got a D-.";
    }
    else
    {
        return "You got a failing grade.";
    }
}
static bool WannaRestart()
{
    bool gettingAnswer = true;
    while (gettingAnswer)
    {
        Console.WriteLine("Would you like to convert another number into a letter grade?");
        Console.WriteLine("Enter 'Yes' or 'Y' to start again, or enter 'No' or 'N'");
        Console.WriteLine("");
        Console.Write("Your Choice: ");
        string userAnswer = Console.ReadLine().ToLower();
        if (userAnswer == "y" || userAnswer == "yes")
        {
            CleanScreen();
            return true;
        }
        else if (userAnswer == "n"|| userAnswer == "no")
        {
            CleanScreen();
            return false;
        }
        else
        {
            Console.WriteLine("");
            Console.WriteLine("I'm sorry, I didnt understand that response. Let's try again.");
            Console.WriteLine("");
        }
    }
    return false;
}