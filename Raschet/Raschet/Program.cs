using System;

class AbsoluteDifference
{
    public static int CalculateDifference(int n)
    {
        int difference = Math.Abs(n - 123); // Абсолютная разность
        return n > 123 ? difference * 3 : difference; // Тройная разность, если n > 123
    }

    static void Main()
    {
        Console.Write("Введите число n: ");
        int n = int.Parse(Console.ReadLine());

        int result = CalculateDifference(n);
        Console.WriteLine($"Результат: {result}");
    }
}
