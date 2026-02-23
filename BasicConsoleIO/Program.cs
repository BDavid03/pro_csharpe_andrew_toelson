Console.WriteLine("**** Basic Console I/O ****");
GetUserData();
Console.ReadLine();
static void GetUserData()
{
    Console.Write("Please Enter your name:");
    string userName = Console.ReadLine();
    Console.Write("Please Enter your age:");
    string usrAge = Console.ReadLine();

    // Change color for fun
    ConsoleColor prevColor = Console.ForegroundColor;
    Console.ForegroundColor = ConsoleColor.Cyan;

    Console.WriteLine($"Hello {userName}, you are {usrAge} years old.");

    Console.WriteLine("Hello {0}, your are {1} years old!", userName, usrAge);

    Console.ForegroundColor = prevColor;
}