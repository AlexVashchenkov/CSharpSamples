int N = Convert.ToInt32(Console.ReadLine());
int last_len = (2 * N) - 1;
int[,] a = new int[N, last_len];

a[0, N-1] = 1;
a[N-1, 0] = 1;
a[N-1, last_len-1] = 1;

for (int i = 1; i < N; i++) {
    for (int j = 1; j < last_len-1; j++) {
        a[i, j] = a[i-1, j-1] + a[i-1, j+1];
    }
}

// печать массива

for (int i = 0; i < N; i++) {
    for (int j = 0; j < last_len; j++) {
        if (a[i, j] == 0) {
            Console.Write(" ");
        }
        else {
            Console.Write(a[i, j]);
        }
    }
    Console.WriteLine();
}