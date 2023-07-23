static double[] Numbers (int length, int Min, int Max)
{
    double [] array = new double[length];
    Random random = new Random();

    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(Min, Max) + random.NextDouble();
    }
    return array;
}


int Min(double [] array)
{
    int length = array.Length;
    double Min = array[0];
    for (int i = 0; i < length; i++)
    {
        if (array[i] < array[i+1])
        {
            Min = array[i];
            int Sumindex = array.Length;
            if (i == Sumindex)              // 23-27 строки - хотел поставить ограничение по обращаемому индексу чтобы не обращался по несуществующему элементу, но оно не работает :(
            {
                break;
            }
        }
    }
    return Convert.ToInt32(Min);
}

int Max (double [] array)
{
    int length = array.Length;
    double Max = array[0];
    for (int i = 0; i < length +1; i++)
    {
        if (array[i] > array[i+1])
        {
            Max = array[i];
            int Sumindex = array.Length;
            if (i == Sumindex)
            {
                break;
            }
        }
    }
    return Convert.ToInt32(Max);
}

int diff (double FMin, double FMax)
{
    double result = FMax - FMin;
    return Convert.ToInt32(result);
}


Console.WriteLine("Введите длину массива:");
int UserLength = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение массива:");
int UserMin = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение массива:");
int UserMax = Convert.ToInt32(Console.ReadLine());

double [] CreateMass = Numbers(UserLength, UserMin, UserMax);
double FinalMin = Min(CreateMass);
double FinalMax = Max(CreateMass);
double Difference = diff(FinalMin, FinalMax);

Console.WriteLine($"Ваш массив: {CreateMass}");
Console.WriteLine($"Минимальное число массива: {FinalMin}");
Console.WriteLine($"Максимальное число массива: {FinalMax}");
Console.WriteLine($"Разница между минимальным и максимальным элементами массива: {Difference}");