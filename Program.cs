Console.WriteLine("Ведите число");
int Num = Convert.ToInt32(Console.ReadLine());

if (Num > 99)
{
   while (Num > 999) 
   {
    Num /= 10;
   }
   int res = Num % 10;
   System.Console.WriteLine(res);
}
else 
{
    Console.WriteLine("Третьей цифры нет");
}
