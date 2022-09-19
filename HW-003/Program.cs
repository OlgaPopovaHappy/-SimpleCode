// Напишите простой конвертер влют
// (без возможности динамического выбора валюты пользователем).
// Валюты заданы хардкодом и не изменяются. Тип валют на выбор программиста.

using static System.Console;
Clear();

double UsdToRub = 66.29;
double UsdToUah = 27.24;

WriteLine("Введите сумму в USD: ");
double USD = double.Parse(ReadLine()!);

WriteLine(USD + " USD в RUB = " + USD * UsdToRub);
WriteLine(USD + " USD в UAH = " + USD * UsdToUah);