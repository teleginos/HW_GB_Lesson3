Console.WriteLine("Введите число для определения является ли оно палиндромом (число должно быть не менее 2-х знаков): ");
string number = Console.ReadLine();
string Flag = "True";

if (number.All(char.IsDigit) && number.Length >= 2)
{
    for(int i = 0; i <= number.Length / 2; i += 1)
    {
        if(number[i] != number[number.Length - 1 - i])
        {
            Flag = "False";
        }
    }
    if(Flag == "True")
    {
        Console.WriteLine($"Число {number} является палиндромом");
    }
    else
    {
    Console.WriteLine($"Число {number} не является палиндромом"); 
    }
}
else
{
    Console.WriteLine("Введены некорректные данные");
}

