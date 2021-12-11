//По двум заданным числам проверять является ли первое квадратом второго
System.Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine());
if(a==b*b)
{
    Console.WriteLine("good");
}
else
{
    Console.WriteLine("hrenovo");
}