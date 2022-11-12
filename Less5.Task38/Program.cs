// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива


// задать с клавиатуры размер массива
Console.Write("Введите длину массива:  ");
int size = Convert.ToInt32(Console.ReadLine());

double[] array = CreateArray(size);

double[] CreateArray(int size)
{
    return new double[size];
}

void FillandPrintArray(double[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        array[i] = Convert.ToDouble(new Random().Next(-10, 1000));
        int x=new Random().Next(-100,100);
        array[i]=array[i]/x;
        array[i]=Math.Round(array[i],2);
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
FillandPrintArray(array);

double Min(double[] mass) 
{                                                  
    double min = mass[0];
    for (int j = 1; j < mass.Length; j++)
    {
        if (min > mass[j]) min = mass[j];
    }
    return min;                          
}
// Console.Write("min: ");
// Console.WriteLine(Min(array));  

double Max(double[] massiv) 
{                                                  
    double max = massiv[0];
    for (int x = 1; x < massiv.Length; x++)
    {
        if (max < massiv[x]) max = massiv[x];
    }
    return max;                          
}
// Console.Write("max: ");
// Console.WriteLine(Max(array));

Console.Write("Разница max и min: ");
void Sum(double A, double B)
{
    Console.WriteLine(A + B);
}
Sum(Min(array),Max(array));

