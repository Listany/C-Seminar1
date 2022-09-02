// Программа принимает на вход число N и выводит все четные числа от 1 до N

System.Console.WriteLine("Введите число:");
string str = Console.ReadLine();

try
{
    int num = int.Parse(str);
    int numStart = 1;

    if (numStart > num)
    {
        System.Console.WriteLine("Введите значение больше 1");
        return;
    }

    while (numStart < num)
    {
        if (numStart % 2 == 0)
        {
            System.Console.WriteLine(numStart);
        }
        numStart++;
    }
}
catch(FormatException)
{
    System.Console.WriteLine("Ошибка при конвертации");
}