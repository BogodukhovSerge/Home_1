// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


System.Console.WriteLine("Введите Xa: ");
int Xa = Convert.ToInt32(Console.ReadLiane());
System.Console.WriteLine("Введите Ya: ");
int Ya =Convert.ToInt32(Console.ReadLiane());
System.Console.WriteLine("Введите Za: ");
int Za = Convert.ToInt32(Console.ReadLiane());
System.Console.WriteLine("Введите Xb: ");
int Xb = Convert.ToInt32(Console.ReadLiane());
System.Console.WriteLine("Введите Yb: ");
int Yb = c(Console.ReadLiane());
System.Console.WriteLine("Введите Zb: ");
int Zb = Convert.ToInt32(Console.ReadLiane());

double rust = Math.Sqrt((Xb-Xa)*(Xb-Xa) + (Yb-Ya)*(Yb-Ya) + (Zb-Za)*(Zb-Za));
System.Console.WriteLine(rust);