// Задача 19
// Напишите программу, которая принимает на вход пятизначноe
// число и проверяет, является ли оно палиндром.

//Console.WriteLine("Введите пятизначное число: ");
//string num = Console.ReadLine();
//int len = num.Length;

//if (len == 5)
//{
//    if(num[0] == num[4] && num[1] == num[3])
//    {
//    Console.WriteLine($"{num} - полиндром");
//    }
//    else
//    {
//    Console.WriteLine($"{num} - Не полиндром");
//    }
//} 
//else
//{
//    Console.WriteLine($"ОШИБКА: {num} - не является пятизначным");
//}

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит
// расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.Clear();
// Console.WriteLine("Введите координаты двух точек");
// Console.Write("Введите x1: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите y1: ");
// int z1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите z1: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите x2: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите y2: ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите z2: ");
// int z2 = Convert.ToInt32(Console.ReadLine());

// double L = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));
// Console.WriteLine("Расстояние между точками равно: " + L);


// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.Write("Введите число: ");
//  int cube = Convert.ToInt32(Console.ReadLine());

//void Cube(int[] cube){
//  int counter = 1;
//  int length = cube.Length;
//  while (counter <  length){
//    cube[counter] = Convert.ToInt32(Math.Pow(counter, 3));
//    counter++;
//  {
// {

// void PrintArry(int[] coll){
//  int count = coll.Length;
//  int index = 1;
//  while(index < count){
//    Console.Write(coll[index]+ ", ");
//    index++;
//  }
//} 

//int[] arry = new int[cube+1];
//Cube(arry);
//PrintArry(arry);