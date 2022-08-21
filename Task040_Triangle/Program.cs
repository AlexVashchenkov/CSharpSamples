double a = new Random().Next(0,10);
double b = new Random().Next(0,10);
double c = new Random().Next(0,10);

Console.WriteLine("a = " + a + "; b = " + b + "; c = " + c);

if (a+b>c & a+c>b & b+c >a)
{
    Console.WriteLine("Три числа являются сторонами треугольника");
}
else
{
    Console.WriteLine("Три числа НЕ являются сторонами треугольника");
}