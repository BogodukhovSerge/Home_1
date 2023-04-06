// //Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int SetNumber(string number = "N")
{
    Console.Write($"Enter number {number}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
int MethodNum(int number)
{
    int i = 0;
    for (; i <= number; i = (i*i*i))
    {
        i++;
    }
    return i;

}

int i = SetNumber();
Console.WriteLine(MethodNum(i));