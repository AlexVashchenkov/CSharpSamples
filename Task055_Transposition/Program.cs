Console.WriteLine("Введите высоту матрицы: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину матрицы: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];

void Fill(int[,] matr){
    for (int i = 0; i < matr.GetLength(0); i++){
        for (int j = 0; j < matr.GetLength(1); j++){
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

void Print(int[,] matr){
    for (int i = 0; i < matr.GetLength(0); i++){
        for (int j = 0; j < matr.GetLength(1); j++){
            Console.Write(matr[i,j] + " ");
        }
        Console.WriteLine();
    }
}
Fill(array);
Console.WriteLine("Исходная матрица\n");
Print(array);

for (int i = 0; i < m; i++){
    for (int j = i; j < n; j++){
        int t = array[i, j];
        array[i, j] = array[j, i];
        array[j, i] = t;
    }
}

Console.WriteLine("Конечная матрица\n");
Print(array);