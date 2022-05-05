///2. Напишите программу, которая будет выдавать 
///название дня недели по заданному номеру.
//3 -> Среда 
///5 -> Пятница

Console.Write("Введите целое число a");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите целое число b");
int num2 = int.Parse(Console.ReadLine());
///Console.Write("Квадрат числа равен -");
int numResult = num1 * num1;
if (numResult == num2)
{
Console.Write("Yes");
}
else
{
Console.Write("No");
}




Console.ReadKey();



