System.Console.WriteLine("Введите номер дня недели");
int Num = Convert.ToInt32(Console.ReadLine());
if (Num > 7)
{
System.Console.WriteLine("Нет такого дня недели");
}
else 
{
bool isMultiplicity (int Num)
{
    return(Num == 7 || Num == 6 );
}
Console.WriteLine(isMultiplicity(Num));
}

// так тоже работает 
// int Num = Convert.ToInt32(Console.ReadLine());

// if (Num > 7)
// {
// System.Console.WriteLine("Нет такого дня недели");
// }
// else 
// {
//     if (Num <=5)
//     {
//         System.Console.WriteLine("нет");
//     }
//     else 
//     System.Console.WriteLine("да");
// }
