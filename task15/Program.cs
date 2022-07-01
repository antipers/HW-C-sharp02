System.Console.WriteLine("Введите число от 1 до 7: ");
int Num;

while (!int.TryParse(Console.ReadLine(), out Num))
{
    System.Console.WriteLine("Введен некорректный символ, введите число от 1 до 7");
}

if (Num > 5 & Num < 8)
{
    System.Console.WriteLine("Сегодня выходной, приходите в другой день");

}
else System.Console.WriteLine("Сегодня будний день");