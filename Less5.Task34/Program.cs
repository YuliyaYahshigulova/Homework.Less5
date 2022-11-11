// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// задать с клавиатуры размер массива
Console.Write("Введите длину массива:  ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArray(size);

int[] CreateArray(int size)
{
    return new int[size];
}

void FillandPrintArray(int[] array)
{
    int size = array.Length;

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

FillandPrintArray(array);

int EvenCount(int[] count)
{
    int result = 0;
    int length = count.Length;

    for (int j = 0; j < length; j++)
    {
        if (array[j] % 2 == 0) result++;
    }
    Console.Write($"{result} ");
    Console.WriteLine();
    return result;
}
Console.Write("Количество четных чисел массива:  ");
EvenCount (array);















