
//1. 1 o'lchamli massive berilgan. Shu masivedagi eng ko'p qatnashgan elementni
//chiqaruvchi dastur tuzing.
namespace HomeWork4
{
    internal class Program
    {
        public static List<int> ServarList = new List<int>();
        static void Main(string[] args)
        {
            FillArray();
            Console.Clear();
            DisplayRun();
            Logic();
        }
        public static void FillArray()
        {
            Console.Write("Nechta element kiritmoqchisiz: ");
            var elementNumber = int.Parse(Console.ReadLine());
            for (var i = 0; i < elementNumber; i++)
            {
                Console.Write($"Array[{i}]: ");
                var element = int.Parse(Console.ReadLine());
                ServarList.Add(element);
            }

        }

        public static void DisplayRun()
        {
            foreach (var item in ServarList)
            {
                Console.Write($" {item}");
            }
            Console.WriteLine();
        }
        public static void Logic()
        {
            var repeatElement = ServarList[0];
            var maxInt = 0;
            for (var i = 0; i < ServarList.Count; i++)
            {
                var count = 0;
                for (var j = 0; j < ServarList.Count; j++)
                {
                    if (ServarList[i] == ServarList[j])
                    {
                        count++;
                    }
                }
                if (count > maxInt)
                {
                    maxInt = count;
                    repeatElement = ServarList[i];
                }
            }
            Console.WriteLine($"Eng ko'p qatnashgan element: {repeatElement}");
            Console.WriteLine($"Necha marta qatnashgan: {maxInt}");
        }
    }
}
