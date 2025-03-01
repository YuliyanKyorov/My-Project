namespace _01.Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            {
                Random rnd = new Random();
                HashSet<int> uniqueNumbers = new HashSet<int>();

                // Генерираме 6 уникални числа
                while (uniqueNumbers.Count < 6)
                {
                    int randomNumber = rnd.Next(1, 50); // Генерира числа от 1 до 49
                    uniqueNumbers.Add(randomNumber); // HashSet автоматично игнорира дубликати
                }

                // Преобразуваме HashSet в масив и сортираме числата
                int[] numbers = new int[6];
                uniqueNumbers.CopyTo(numbers);
                Array.Sort(numbers);

                // Извеждаме числата
                foreach (var number in numbers)
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}

