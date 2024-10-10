Random rnd = new Random();

int myRandomNum;

int RandomSum = 0;

for(int i = 0; i < 3; i++) // valib kolm random numbrit et printida, siis lopetab too
{
    myRandomNum = rnd.Next(0, 11); // valid vahemiku 0, 11 valib 0st 10ni
    RandomSum = RandomSum + myRandomNum;
    Console.WriteLine($"My random number is: {myRandomNum}");
}
Console.WriteLine($"Sum of random numbers: {RandomSum}"); 