using Focus;

int temp;
string name = "";
string occupation = "";

Console.WriteLine("========================");
Console.WriteLine("Hello! Welcome to Focus!");

Console.Write("Please, type your username: ");
name = Console.ReadLine();

Console.WriteLine("\n========================");
Console.WriteLine("Now please, choose one of the occupations below by writing the number: ");
Console.WriteLine("[1] Elementary school student\n[2] High school student\n[3] Higher education student\n[4] Professional\n[5] Not currently studying or working\n[6] Other");
Console.Write("\nYour Selection: ");
temp = int.Parse(Console.ReadLine());

if (temp == 6)
{
    Console.Write("\nType your current occupation: ");
    occupation = Console.ReadLine();
}
else
{
    occupation = Player.DefineOccupation(temp);
}

Player player;
player = new Player(name, occupation);

temp = 0;
while (temp != 3)
{
    player.FocusMode = false;
    Console.WriteLine("\n========================");

    if (temp == 1)
        Console.WriteLine("Focus Mode is off.\n");

    if(temp == 2)
        Console.WriteLine("You have completed " + player.FocusSessions + " Focus Sessions.\n");

    Console.WriteLine("What would you like to do now, " + player.Name + "?");
    Console.WriteLine("[1] Turn on Focus Mode");
    Console.WriteLine("[2] Check Focus Count");
    Console.WriteLine("[3] End Session");
    Console.Write("\nPlease, type a number: ");
    temp = int.Parse(Console.ReadLine());

    if(temp == 1)
    {
        player.FocusMode = true;
        player.FocusSessions++;
        Console.WriteLine("\n========================");
        Console.WriteLine("Focus Mode is on.");
        Console.WriteLine("\n[1] Turn off Focus Mode");
        Console.WriteLine("[3] End Session");
        Console.Write("\nPlease, type a number: ");
        temp = int.Parse(Console.ReadLine());
    }
    
}

Console.WriteLine("\n\n\n========================");
Console.WriteLine("See you later " + player.Name + "!");
