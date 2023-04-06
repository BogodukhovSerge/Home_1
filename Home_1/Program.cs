// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет,
//  является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Vvedite pyateznachnoe cheslo: ");
int numA = Convert.ToInt32(Console.ReadLiane());

int i = 0;
for (; i <= numA; i = numA / 10 % 10)
{
    i++;
}
if  (i(5) == i(1) || i(4) == i(2))
{
    Console.WriteLine("палиндром");
}        
Console.WriteLine("не палиндром");