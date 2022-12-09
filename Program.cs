// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

/*
Console.WriteLine("Input the three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = number / 10 % 10;
Console.WriteLine($"{result}");
*/
/* Павел, можно же было решить через индекс?


Console.WriteLine("Input the three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

string numberText = Convert.ToString(number);
Console.WriteLine("The second number is " + numberText[1]);

*/

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

/*
Console.WriteLine("Input the number: ");
int number = Convert.ToInt32(Console.ReadLine());

string numberText = Convert.ToString(number);
if (numberText.Length > 2)
{
    Console.WriteLine("The third number is " + numberText[2]);
}
else 
{
    Console.WriteLine("No third number!");
}
*/


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Input the day of the week: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 6| number == 7) 
{
    Console.WriteLine("Weekend");
}
else 
{
    Console.WriteLine("Not weekend");
}








