﻿int [] arrayNum (int length)
{
    int [] array = new int[length];
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(100, 1000);
    }
    return array;
}

int EvenNums(int [] RandomArray)
{
    int len = RandomArray.Length;
    int count = 0;
    for (int i = 0; i < len; i++)
    {
        if(RandomArray[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

Console.WriteLine("Введите длину массива: ");
int UserLen = Convert.ToInt32(Console.ReadLine());

int [] mass = arrayNum(UserLen);
int result = EvenNums(mass);

Console.WriteLine(string.Join(",", mass)); // Join - немного подсмотрел на stackoverflow, так как вместо массива выводилось System.Int32[]

Console.WriteLine($"Количество четных чисел в массиве: {result}");