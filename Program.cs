System.Console.WriteLine("Введите число");
int Num = Convert.ToInt32(Console.ReadLine());

if (Num > 99 && Num < 1000)
{
    int res = (Num % 100 - Num % 10) / 10;
    Console.WriteLine(res);
}
else 
{
    Console.WriteLine("Число не является трехзначным");
}

