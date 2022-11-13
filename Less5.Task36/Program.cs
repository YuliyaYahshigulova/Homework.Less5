// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

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
        array[i] = new Random().Next(-10, 10);
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

FillandPrintArray(array);

Console.Write("Сумма элементов массива: ");
void OddSumCount(int[] count)
{
    int length = count.Length;
    int sum = 0;
    for (int j = 0; j < length; j = j + 2)
    {
        sum = sum + array[j];
    }
    
    Console.Write(sum);
    Console.WriteLine();
}

OddSumCount(array);









