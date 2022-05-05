/// Напишите программу, которая на вход принимает два 
//числа и проверяет, является ли первое число квадратом 
//второго.

Console.Write("Введите целое число 1 ->");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите целое число 2 ->");
int num2 = int.Parse(Console.ReadLine());
bool result = num2 * num2 == num1;
Console.WriteLine(result ? "Yes" : "No");








