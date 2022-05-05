// Напишите программу, которая будет выдавать 
///название дня недели по заданному номеру.
//3 -> Среда 
///5 -> Пятница



string dayweek = Console.ReadLine();
if(dayweek == "1") Console.WriteLine("Понедельник");
else if (dayweek == "2") Console.WriteLine("Вт");
else if (dayweek == "3") Console.WriteLine("Ср");
else if (dayweek == "4") Console.WriteLine("Чт");
else if (dayweek == "5") Console.WriteLine("Пт");
else if (dayweek == "6") Console.WriteLine("Сб");
else if (dayweek == "7") Console.WriteLine("Вс");
else Console.WriteLine("Ошибка ввода");

