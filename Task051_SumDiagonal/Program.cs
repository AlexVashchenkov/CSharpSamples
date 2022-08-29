Console.Write("Введите высоту матрицы: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите длину матрицы: ");
int n = int.Parse(Console.ReadLine());
int[,] matr = new int[m, n];

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

Console.WriteLine("Исходная матрица: ");
Fill(matr);
Print(matr);

int sum = 0;
Console.WriteLine();
for (int i = 0; i < matr.GetLength(0); i++){
    for (int j = 0; j < matr.GetLength(1); j++){
        if (i == j){
            sum = sum + matr[i, j];
        }
    }    
}
Console.WriteLine("Сумма элементов главной диагонали = " + sum);



