// принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Write("Введите любое натуральное число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int a = 1;
Console.Write("Таблица кубов чисел от 1 до N: ");
while (a <= n)
{
    Console.Write($" {a*a*a} ");
    a++;
}
