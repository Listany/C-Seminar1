System.Console.WriteLine("Введите число: ");
string num = Console.ReadLine();
try
{
    int numConv = Convert.ToInt32(num);

    int result = numConv % 2;
    if (result == 0)
    {
        System.Console.WriteLine("Введенное число - четное");
    }
    else
    {
        System.Console.WriteLine("Введенное число - нечетное");
    }
}
catch (FormatException)
{
    System.Console.WriteLine("Ошибка при конвертации");
}

