Console.WriteLine("Введите число: ");
try
{
    int a = Convert.ToInt32(Console.ReadLine());
    if (a % 2 == 0) Console.WriteLine("Четное");
    else Console.WriteLine("Нечетное");
}
catch 
{
    Console.WriteLine("Нужно число");
}
