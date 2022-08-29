Console.Write("Введите длину массива: ");
int length = int.Parse(Console.ReadLine());
int[] array = new int[length];

for (int i = 0; i < array.Length; i++){
    array[i] = new Random().Next(100, 1000);
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
}

int[] ArrayCopy(int[] array)
{
    int[] ResArr = new int[length];
    for(int i = 0; i < length; i++)
    {
        ResArr[i] =  array[i];
    }
    return ResArr;
}

Console.Write("Ваш массив: ");
PrintArray(array);
Console.WriteLine();
Console.Write("Копия вашего массива: ");
PrintArray(ArrayCopy(array));