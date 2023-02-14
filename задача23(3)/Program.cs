// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void Cube (int uN)
{
    int current = 1;
    while (current <= uN)
    {
        int res = current * current * current;
        Console.Write($"{res}, ");
        current++;

    }
}
Console.Write("imput your number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 1)
{
    Console.Write($"{number} -> ");
    Cube(number);
}
else Console.WriteLine("imput number again");

