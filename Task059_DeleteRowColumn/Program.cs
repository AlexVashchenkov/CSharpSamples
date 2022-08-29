void Fill(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)//перебираем строки
    {
        for (int j = 0; j < matr.GetLength(1); j++)//перебираем столбцы
        {
            //заполняем ячейку случайными числами от -9 до 9 с плавающей запятой
            matr[i, j] = (new Random()).Next(-99, 100);
        }
    }
}

void Print(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        Console.Write($"[");
        for (int j = 0; j < matr.GetLength(1) - 1; j++)
        {
            Console.Write($" {matr[i, j]} |");
        }
        Console.WriteLine($" {matr[i, matr.GetLength(1) - 1]} ]");
        
    }
}

int[,] CutLeastElementCross(int[,] matrix){
    int indexI = 0;
    int indexJ = 0;
    int min = matrix[0, 0];
    for (int i = 0; i < matrix.GetLength(0); i++){
        for (int j = 0; j < matrix.GetLength(1); j++){
            if (matrix[i, j] < min){
                min = matrix[i, j];
                indexI = i;
                indexJ = j;
            }
        }
    }
    int flagI = 0;
    int flagJ = 0;
    int[,] resultMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    for (int i = 0; i < matrix.GetLength(0) - 1; i++){
        for (int j = 0; j < matrix.GetLength(1) - 1; j++){
            if (i >= indexI) { flagI = 1; }
            else { flagI = 0; }
            if (j >= indexJ) { flagJ = 1; }
            else { flagJ = 0; }
            resultMatrix[i, j] = matrix[i + flagI, j + flagJ];
        }
    }
    return resultMatrix;
}


int[,] matrix = new int[5, 5];
Fill(matrix);
Print(matrix);
Console.WriteLine();
int[,] matrix2 = CutLeastElementCross(matrix);
Print(matrix2);

