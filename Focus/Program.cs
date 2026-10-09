using Focus;

int temp;
string name = "";
string occupation = "";

// Set Player
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

// Run Focus
temp = 0;
while (temp != 4)
{
    player.focusMode = false;
    Console.WriteLine("\n========================");

    // Player finished Focus and earned XP
    if (temp == 1)
    {
        Console.WriteLine("Focus Mode is off.\n");
        //Add xp
        player.xp = ProgressionSystem.AddXp(player.xp);
        //Check level up
        if (ProgressionSystem.LevelCheck(player) == true)
            Console.WriteLine("Level Up! You've reached Level " + player.level + "!");
    }

    if (temp == 2)
        Console.WriteLine("You have completed " + player.focusSessions + " Focus Sessions.\n");

    if (temp == 3)
        Console.WriteLine(ProgressionSystem.GetXpStatus(player.level, player.xp));

    //Menu
    Console.WriteLine("What would you like to do now, " + player.name + "?");
    Console.WriteLine("[1] Turn on Focus Mode");
    Console.WriteLine("[2] Check Focus Count");
    Console.WriteLine("[3] Check XP information");
    Console.WriteLine("[4] End Session");
    Console.Write("\nPlease, type a number: ");
    temp = int.Parse(Console.ReadLine());

    //Focus On
    if (temp == 1)
    {
        player.focusMode = true;
        player.focusSessions++;
        Console.WriteLine("\n========================");
        Console.WriteLine("Focus Mode is on.");
        Console.WriteLine("\n[1] Turn off Focus Mode");
        Console.WriteLine("[4] End Session");
        Console.Write("\nPlease, type a number: ");
        temp = int.Parse(Console.ReadLine());
    }

}

Console.WriteLine("\n\n\n========================");
Console.WriteLine("See you later " + player.name + "!");
