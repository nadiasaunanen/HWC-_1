Console.Write("Введите первое число: ");
double firstDigit = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второе число: ");
double secondDigit = Convert.ToDouble(Console.ReadLine());
if (firstDigit > secondDigit)
{
    Console.WriteLine("Наибольшее число " + firstDigit + " Наименьшее число " + secondDigit);
}
else
{
    Console.WriteLine("Наибольшее число " + secondDigit + " Наименьшее число " + firstDigit);
}