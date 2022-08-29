Console.Write("Введите M: ");
int M = int.Parse(Console.ReadLine());
Console.Write("Введите N: ");
int N = int.Parse(Console.ReadLine());

void MToN(int i){
    if (i == N){
        Console.WriteLine(i);
    }
    else {
        Console.Write(i + ", ");
        i++;
        MToN(i);
    }
}

MToN(M);