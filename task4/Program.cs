Console.WriteLine("Введите положительное число: ");
try
{
    int a = Convert.ToInt32(Console.ReadLine());
    if (a <= 0) Console.WriteLine("Нужно положительное число");
    else 
    {
        int i = 4;
        if (a >= 2) Console.Write(2);
        while (i <=a)
            {
                Console.Write(", " + i);
                i = i + 2;         
            }
    }
}
catch 
{
    Console.WriteLine("Нужно число");
}
