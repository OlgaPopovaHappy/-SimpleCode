
using static System.Console;
Clear();

double firstValue, secondValue, thirdValue;
WriteLine("Введите первое число: ");
firstValue = double.Parse(ReadLine()!);
WriteLine("Введите второе число: ");
secondValue = double.Parse(ReadLine()!);
WriteLine("Введите третье число: ");
thirdValue = double.Parse(ReadLine()!);

double sumResult = firstValue + secondValue+ thirdValue;
double multResult = firstValue * secondValue * thirdValue;
WriteLine($"Сумма чисел {firstValue}, {secondValue} и {thirdValue} = {sumResult}");
WriteLine($"Произведение чисел {firstValue}, {secondValue} и {thirdValue} = {multResult}");