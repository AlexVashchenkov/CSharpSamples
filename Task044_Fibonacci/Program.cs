int number = 20;
int firstElem = 1;
int secondElem = 1;

Console.WriteLine("Последовательность Фибоначчи");
Console.WriteLine($"1. {firstElem}");
Console.WriteLine($"2. {secondElem}");

for (int i = 3; i <= number; i++)
{
    int nextElem = firstElem + secondElem;
    Console.WriteLine($"{i}. {nextElem}");
    firstElem = secondElem;
    secondElem = nextElem;
}