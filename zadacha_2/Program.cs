/*
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int ad = 0;
int count = Convert.ToString(a).Length;
for (int i = 0; i < count; i++)
{
    ad = a - a%10;
    sum+= a - ad;
    a/=10;
}
Console.WriteLine($"Сумма цифр в числе - {sum}");