int[] CreatingAnArray(int[] point)
{
    for(int i = 0; i <= 2; i += 1)
    {   
        double num;
        string number = Console.ReadLine();
        if(double.TryParse(number, out num))
        {
            point[i] = int.Parse(number);
        }
        else
        {
            Console.WriteLine("Введены некорректные значения! Повторите ввод данных: ");
            point = CreatingAnArray(point);
            break;
        }
    }
    return point;
}   

int[] point1 = new int[3];
int[] point2 = new int[3];

Console.WriteLine("Введите координыты для первой точки в системе X, Y, Z каждое с новой строки: ");
point1 = CreatingAnArray(point1);

Console.WriteLine("Введите координыты для второй точки в системе X, Y, Z каждое с новой строки: ");
point2 = CreatingAnArray(point2);

double result = Math.Pow(point2[0] - point1[0], 2) + Math.Pow(point2[1] - point1[1], 2) + Math.Pow(point2[2] - point1[2], 2);
Console.WriteLine($"Расстояние между двумя введенными точками = {Math.Round(Math.Sqrt(result), 2)}");
