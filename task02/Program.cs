// Даны два числа. Показать большее и меньшее число
void SravnitChisla(int a, int b)
{
    if (a > b)
    {
        System.Console.WriteLine($"max a = {a}, min b = {b}");
    }
    else
    {
        System.Console.WriteLine($"max b = {b}, min a = {a}");
    }
}
SravnitChisla(33, 40);
