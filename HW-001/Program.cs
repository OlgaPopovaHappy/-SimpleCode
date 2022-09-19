
using static System.Console;
Clear();

double firstValue, secondValue;
WriteLine("Введите первое число: ");
firstValue = double.Parse(ReadLine()!);
WriteLine("Введите второе число: ");
secondValue = double.Parse(ReadLine()!);
double result = (firstValue + secondValue)/2;
WriteLine("Средее арифметическое двух чисел = " + result);