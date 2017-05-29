namespace InsertionSort
{
    using System;
    using System.Linq;

    public class InsertionSort
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int firstUnsorted = 0; firstUnsorted < numbers.Length - 1; firstUnsorted++)
            {
                var i = firstUnsorted + 1;
                while (i > 0)
                {
                    if (numbers[i] < numbers[i - 1])
                    {
                        var temp = numbers[i];
                        numbers[i] = numbers[i - 1];
                        numbers[i - 1] = temp;
                    }
                    i--;
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
