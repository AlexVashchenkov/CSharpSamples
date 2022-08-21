int[] array = new int[10];
Console.Write("Ваш массив: ");
for (int i = 0; i < array.Length; i++){
    array[i] = new Random().Next(100, 1000);
    Console.Write(array[i] + " ");
}

for (int i = 0; i < array.Length / 2; i++){
    int t = array[i];
    array[i] = array[array.Length - i - 1];
    array[array.Length - i - 1] = t;
}
Console.WriteLine();
Console.Write("Перевёрнутый массив: ");
for (int i = 0; i < array.Length; i++){
    Console.Write(array[i] + " ");
}
