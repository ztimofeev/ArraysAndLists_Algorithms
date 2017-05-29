namespace ArrayContainsElement
{
    using System;
    using System.Linq;

    public class ArrayContainsElement
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            var seekingNum = int.Parse(Console.ReadLine());

            string result = "no";

            foreach (var number in numbers)
            {
                if (number == seekingNum)
                {
                    result = "yes";
                    break;
                }
            }

            Console.WriteLine(result);
        }
    }
}
