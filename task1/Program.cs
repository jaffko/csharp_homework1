Console.Write("Введите 2 числа: ");
try
{
    int first_num = Convert.ToInt32(Console.ReadLine());
    int second_num = Convert.ToInt32(Console.ReadLine());
    if (first_num > second_num)
        Console.WriteLine("Макисмальное -> " + first_num);
    else if (second_num > first_num)
        Console.WriteLine("Максимальное -> " + second_num);
    else Console.WriteLine("Числа равны"); 
}
catch
{
    
    Console.WriteLine("Нужно число");
}