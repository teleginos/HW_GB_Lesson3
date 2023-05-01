Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

for(int i = 1; i <= number; i += 1)
{
    if(i != number)
    {
        Console.Write($"{Math.Pow(i, 3)}, ");
    }
    else
    {
        Console.Write(Math.Pow(i, 3));
    }
}