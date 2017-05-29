namespace SmallestElementInArray
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SmallestElement
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            var smallest = int.MaxValue;

            foreach (var number in numbers)
            {
                if (number < smallest)
                {
                    smallest = number;
                }
            }

            Console.WriteLine(smallest);
        }
    }
}
