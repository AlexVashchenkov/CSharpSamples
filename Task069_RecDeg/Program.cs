Console.Write("Введите A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите B: ");
int B = Convert.ToInt32(Console.ReadLine());

int Deg(int A, int B){
    if (B == 1){
        return A;
    } else {
        return A * Deg(A, B-1);
    }
}

Console.WriteLine($"Число {A} в степени {B} = " + Deg(A, B));