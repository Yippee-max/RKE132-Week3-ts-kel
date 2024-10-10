int sum = 0;

for (int i = 1; i < 11; i++) // i-- = i - 1
{
    Console.WriteLine($"i = {i}"); // i tegelik vaartus ei soltu + 1-st, mojutab ainult writeline
    Console.WriteLine($"Current total: {sum}");
    sum = sum + i; // sum += i;
}
Console.WriteLine($"Final totalsum: {sum}");