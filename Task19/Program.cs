/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
14212 -> нет
12821 -> да
23432 -> да */

Console.WriteLine("Enter five digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 10000 && number <= 99999)
Console.WriteLine(Palindrome(number) ? "Yes" : "No");
else Console.WriteLine("You entered not a five-digit number");

bool Palindrome(int num)
{
int pal = 0;
while (number > 0) 
{
    pal = pal * 10 + number % 10; number /= 10;
}
return num == pal;
}





