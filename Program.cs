// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.WriteLine ("Введите трехзначное число:");
int number1 = Convert.ToInt32(Console.ReadLine());

int digit1 = number1 / 100;
int digit2 = (number1 - digit1*100)/ 10;
int digit3 = number1 % 10;

Console.WriteLine(digit2);