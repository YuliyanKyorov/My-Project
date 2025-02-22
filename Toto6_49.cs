using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int[] numbers = new int[6];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(1, 50); // Генерира случайно число между 1 и 49
        }

        Array.Sort(numbers); // Сортира числата

        Console.WriteLine("Вашите тото числа са:");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
    }
}