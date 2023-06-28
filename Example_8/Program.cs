Console.WriteLine("Введите число: ");
double number = Convert.ToDouble(Console.ReadLine());
int count = 1;
if (number < 1)
{
     Console.Write("Недопустимые значения");
}
while (count < number)
{
    if (count % 2 == 0)
    {
        Console.Write(count + ", ");
        count++;
    }
    else
    {
        count++;
    }
}