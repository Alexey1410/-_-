// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

//Console.Write("Введите первое число: ");
//int numA = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите второе число: ");
//int numB = Convert.ToInt32(Console.ReadLine());

//int Exponentiation(int numA, int numB)
//{
//    int result = 1;
//    for( int i = 1; i <= numB; i++)
//    {
//        result = result * numA;
//    }
//    // int result = Math.Pow(numA, numB);
//    return result;
//}

//int exponentiation =Exponentiation(numA, numB);
//Console.WriteLine("Ответ: " + exponentiation);

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

//Console.WriteLine("Введите число: ");
//int n = Convert.ToInt32(Console.ReadLine());

//int SumNumber(int n)
//{
//int count = Convert.ToString(n).Length;
//int advance = 0;
//int result = 0;
//
//    for(int i = 0; i <= count; i++)
//    {
//        advance = n - n % 10;
//        result = result + (n - advance);
//        n = n / 10;
//    }
//return result;
//}
//int sumNumber = SumNumber(n);
//Console.WriteLine("Сумма цифр в числе: " + sumNumber);


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

//int[] array = new int[8];

//for (int i = 0; i < array.Length; i++)
//array[i] = new Random().Next(0, 100);

//Console.WriteLine("[" + string.Join(", ", array) + "]");