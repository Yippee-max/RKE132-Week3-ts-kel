
Random rnd = new Random();

int cpuRandom;

bool loopActive = true; //bool on kas true voi false

while(loopActive)
{
    cpuRandom = rnd.Next(1, 4);
    //Console.WriteLine($"Cpu generated numbers is: {cpuRandom}");
    Console.WriteLine("Make a guess. Enter a number 1-3:");
    int userNumber = Int32.Parse(Console.ReadLine());

    if (userNumber == cpuRandom)
    {
        Console.WriteLine($"Congrats! You guessed correctly! Your number was {cpuRandom}");
        //loopActive = false;
        break;
    }
    else if (userNumber >= 4)
    {
        Console.WriteLine("Please enter a valid number from 1 to 3");
    }
    else
    {
        Console.WriteLine("Try again!");
    }
}
Console.WriteLine($"Have a nice day!");