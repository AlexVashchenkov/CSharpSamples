int a = new Random().Next(0,100);;

void ToBin(int a){
    if (a > 1){
        ToBin(a / 2);
        Console.Write(a % 2);
    }
    else {
        Console.Write(a % 2);
    }
}
Console.WriteLine("Ваше число - " + a);
Console.Write("Ваше число в двоичной системе счисления - ");
ToBin(a);