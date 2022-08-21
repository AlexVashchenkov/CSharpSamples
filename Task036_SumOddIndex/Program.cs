int[] array = new int[10];
Console.Write("Ваш массив: ");
for (int i = 0; i < array.Length; i++){
    array[i] = new Random().Next(100, 1000);
    Console.Write(array[i] + " ");
}
int sum = 0;
Console.WriteLine();

for(int i=1; i < array.Length; i+=2){
    sum += array[i];
}
Console.WriteLine("Сумма элементов на нечётных индексах = " + sum);