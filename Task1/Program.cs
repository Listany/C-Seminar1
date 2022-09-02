// Программа на вход принимает 2 числа и выдает, какое число большее, какое меньшее

System.Console.WriteLine("Введите первое число: ");
string num1 = Console.ReadLine();
int num_conv1 = Convert.ToInt32(num1);

System.Console.WriteLine("Введите второе число: ");
string num2 = Console.ReadLine();
int num_conv2 = int.Parse(num2);

if (num_conv1 > num_conv2)
{
    System.Console.WriteLine("Число, введенное первым " + num_conv1 + " является большим, чем число, введенное вторым " + num_conv2);
}
else
{
    System.Console.WriteLine("Число, введенное вторым " + num_conv2 + " является большим, чем число, введенное первым " + num_conv1);
}