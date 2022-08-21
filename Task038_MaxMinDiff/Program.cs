double[] array = new double[10];
Console.Write("Ваш массив: ");

for (int i = 0; i < array.Length; i++){
    array[i] = Math.Round(new Random().NextDouble(), 2);
    Console.Write(array[i] + " ");
}

double array_max = -1000000;
double array_min = 1000000;
for (int i = 0; i < array.Length; i++){
    if (array[i] > array_max){
        array_max = array[i];
    }
    if (array[i] < array_min){
        array_min = array[i];
    }
}

Console.WriteLine();
Console.WriteLine("Максимальное значение = " + array_max);
Console.WriteLine("Минимальное значение = " + array_min);
Console.WriteLine("Разность = " + Math.Round(array_max - array_min, 2));

