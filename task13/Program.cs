System.Console.WriteLine("Введите число- ");
int Num;

while (!int.TryParse(Console.ReadLine(), out Num))
{
    System.Console.WriteLine("Введен некорректный символ, введите трехзначное ЧИСЛО");
}

System.Console.WriteLine($"Число {Num} удовлетворяет критериям");



if (Num < 99)
{
    System.Console.WriteLine("Третья цифра числа отсутствует");
}


int a = int.Parse(Convert.ToString(Num)[2].ToString());
System.Console.WriteLine(a);
