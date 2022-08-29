Console.Write("Задайте количество строк в массиве: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Задайте количество столбцов в массиве: ");
int n = int.Parse(Console.ReadLine());
int[,] array = new int[m, n];

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}
void SortArray(int[,] array)  //сортируем массив от максимума к минимуму
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)

            for (int a = 0; a < array.GetLength(0); a++)
                for (int b = 0; b < array.GetLength(1); b++)
                    if (array[a, b] > array[i, j])
                    {
                        int temp = array[i, j];
                        array[i, j] = array[a, b];
                        array[a, b] = temp;
                    }
}

Console.WriteLine("Наш массив: ");
FillArray(array);
PrintArray(array);
SortArray(array);
Console.WriteLine("Частотный анализ массива: ");
int temp = array[0, 0];
int count = 0;
for (int i = 0; i < array.GetLength(0); i++)  // непосредственно сам частотный анализ
    for (int j = 0; j < array.GetLength(1); j++)
        if (array[i, j] == temp) count++;
        else
        {
            Console.WriteLine($"Число {temp} встречается {count:00} раз, частота {count*100/ array.Length:00.0} %");
            count = 1;
            temp = array[i, j];
        }
Console.WriteLine($"Число {array[array.GetLength(0) - 1, array.GetLength(1) - 1]} встречается {count:00} раз, частота {count * 100 / array.Length:00.0} %");
Console.WriteLine();
