Console.Write("Введите N: ");
int N = int.Parse(Console.ReadLine());

void PrintNumbers(int i){
    if (i == N){
        Console.WriteLine(i);
    }
    else {
        Console.Write(i + ", ");
        i++;
        PrintNumbers(i);
    }
}

PrintNumbers(1);