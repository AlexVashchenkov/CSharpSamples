Console.Write("Введите N: ");
int N = int.Parse(Console.ReadLine());

int Sum(int N){
    if (N == 0){
        return 0;
    } else {
        return (N % 10) + Sum(N / 10);
    }
}

Console.WriteLine("Сумма цифр числа: " + Sum(N));