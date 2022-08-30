// принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Write("Введите любое пятизначное число :");
int num = Convert.ToInt32(Console.ReadLine());
 int num1 = num / 10000;
 int num2 = num % 10;
 if (num1 == num2)
 {
    num = num - (num1*10000);
    num = num / 10;
    num1 = num / 100;
    num2 = num % 10;
    if (num1 == num2) Console.Write("Это число палиндром");
    else Console.Write ("Это число не палиндром");
 }
 else Console.Write("Это число не палиндром");
