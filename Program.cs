// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Clear();
try
{
    Console.WriteLine ("Введите первое число ");
    int a = Convert.ToInt32 (Console.ReadLine());
    Console.WriteLine ("Введите второе число");
    int b = Convert.ToInt32 (Console.ReadLine());

    if (a>b) 
    {
        Console.WriteLine ("Первое число больше второго числа");
    }
    else if (a<b) Console.WriteLine("Первое число меньше второго числа");
    else Console.WriteLine ("Первое число равно второму числу");
}
catch
{
 Console.WriteLine ("Убедитесь, что вы ввели два числа");
}
