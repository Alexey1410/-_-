// Напишите программу, которая принимает на вход трёхзначное
// число и на выходе показывает вторую цифру этого числа.
int GenerateRandomNamber()
{
    int n = new Random().Next(100, 1000);
    return n;
}
void CompraiseNambers()
{
    int n = GenerateRandomNamber();
    Console.WriteLine(n);
    Console.WriteLine(Convert.ToString(n)[1]);
}

CompraiseNambers();
