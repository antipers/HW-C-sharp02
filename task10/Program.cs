System.Console.WriteLine("Введите трехзначное число- ");
int Num;
int a;
int b;
while (!int.TryParse(Console.ReadLine(), out Num))
{
    System.Console.WriteLine("Введен некорректный символ, введите трехзначное ЧИСЛО");
}

System.Console.WriteLine($"Число {Num} удовлетворяет критериям");

while (Num > 999 | Num < 100)
{
    System.Console.WriteLine("Введен некорректное число, введите ТРЕХЗНАЧНОЕ");
    int.TryParse(Console.ReadLine(), out Num);
}

{System.Console.WriteLine($"Число {Num} является трехзначным, выполняется вычисление ...");

 a = Num % 100;
b = a / 10;
System.Console.WriteLine(b);
}


