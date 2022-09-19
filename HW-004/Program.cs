using static System.Console;
Clear();

Write("Введите число: ");
int number = int.Parse(ReadLine()!);
if (number % 2 == 0)
{
    WriteLine($"{number} - четное число.");
}
else
{
    WriteLine($"{number} - нечетное число.");
}