int i = 1;
bool not =true;

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Четные число от 1 до " + n);
while (i <= n)
{
    if (i % 2 != 1 )
    {
        Console.Write(i + ", ");
        not = false;
    }
    i++;
}

if (not)
{
    Console.WriteLine("Нет четных чисел.");
}
