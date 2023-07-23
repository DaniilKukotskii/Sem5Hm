int [] Create_array(int length, int min_value, int max_value)
{
    int [] array = new int[length];
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(min_value, max_value);
    }
    return array;
}

int sum (int [] Final_array)
{
    int len = Final_array.Length;
    int sum = 0;
    for (int i = 1; i < len; i += 2)
    {
        sum += Final_array[i];
    }
    return sum;
}

Console.WriteLine("Введите длину массива:");
int UserLength = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение массива:");
int UserMin = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение массива:");
int UserMax = Convert.ToInt32(Console.ReadLine());

int [] User_Final_Array = Create_array(UserLength, UserMin, UserMax);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {sum(User_Final_Array)}");
Console.WriteLine(string.Join(",", User_Final_Array));