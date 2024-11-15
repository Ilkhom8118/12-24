// ===================================================== Lesson - 1 =====================================================

//N ta elementdan iborat 1 o‘lchamli list berilgan. 3 xonali elementlarini miqdorini toping.

//namespace ListMassive
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("Enter Number: ");
//            var sizeArray = int.Parse(Console.ReadLine());
//            var number = new int[sizeArray];
//            FillArray(number);
//            int oddNumber;
//            int evenNumber;
//            OddAndEven(number, out oddNumber, out evenNumber);
//            Console.WriteLine($" Toq: {oddNumber}, Juft: {evenNumber}");
//        }
//        public static void FillArray(int[] num)
//        {
//            for (var i = 0; i < num.Length; i++)
//            {
//                Console.Write($"{i}: ");
//                num[i] = int.Parse(Console.ReadLine());
//            }
//        }
//        public static void OddAndEven(int[] num, out int oddCount, out int evenCount)
//        {
//            oddCount = 0;
//            evenCount = 0;
//            for (var i = 0; i < num.Length; i++)
//            {
//                if (num[i] % 2 == 0)
//                {
//                    evenCount++;
//                }
//                else
//                {
//                    oddCount++;
//                }
//            }
//        }

//    }
//}


// ===================================================== Lesson - 1 =====================================================

//N ta elementdan iborat 1 o‘lchamli list berilgan. 3 xonali elementlarini miqdorini toping.
//namespace ListMassive
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("Enter number: ");
//            int sizeArray = int.Parse(Console.ReadLine());
//            var number = new int[sizeArray];
//            FillArray(number);
//            int count;
//            ThirdNumbers(number, out count);
//        }
//        public static void FillArray(int[] number)
//        {
//            for (var i = 0; i < number.Length; i++)
//            {
//                Console.Write($"{i}: ");
//                number[i] = int.Parse(Console.ReadLine());
//            }
//        }
//        public static void ThirdNumbers(int[] num, out int count)
//        {
//            count = 0;
//            for (var i = 0; i < num.Length; i++)
//            {
//                if (num[i] > 99 && num[i] < 1000)
//                {
//                    count++;
//                }
//            }
//            Console.WriteLine($"3 xonalik son: {count}");
//        }

//    }
//}

// ===================================================== Lesson - 2 =====================================================

//N ta elementdan iborat 1 o‘lchamli list berilgan. Juft elementlarini miqdorini toping.
//namespace ListMassive
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("Enter number: ");
//            int sizeArray = int.Parse(Console.ReadLine());
//            var number = new int[sizeArray];
//            FillArray(number);
//            int evenNumberCount;
//            EvenNumberCount(number, out evenNumberCount);
//        }
//        public static void FillArray(int[] num)
//        {
//            for (var i = 0; i < num.Length; i++)
//            {
//                Console.Write($"Array [{i}]: ");
//                num[i] = int.Parse(Console.ReadLine());
//            }
//        }
//        public static void EvenNumberCount(int[] num, out int evenCounts)
//        {
//            evenCounts = 0;
//            foreach (var number in num)
//            {
//                if (number % 2 == 0)
//                {
//                    evenCounts++;
//                }
//            }
//            Console.WriteLine($"Juft sonlar soni: {evenCounts}");
//        }

//    }
//}


// ===================================================== Lesson - 3 =====================================================

//N ta elementdan iborat 1 o‘lchamli list berilgan. Juft elementlarini miqdorini toping.
//namespace ListMassive
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("Enter number: ");
//            var sizeArray = int.Parse(Console.ReadLine());
//            var number = new int[sizeArray];
//            FillArray(number);
//            int oddCount;
//            var listSizeArray = new List<int>(number);
//            OddCount(listSizeArray, out oddCount);
//            Console.WriteLine(oddCount);
//        }
//        public static void FillArray(int[] num)
//        {
//            for (var i = 0; i < num.Length; i++)
//            {
//                Console.Write($"Array[{i}]: ");
//                num[i] = int.Parse(Console.ReadLine());
//            }
//        }

//        public static void OddCount(List<int> num, out int oddCount)
//        {
//            oddCount = 0;
//            foreach (var number in num)
//            {
//                if (number % 2 == 1)
//                {
//                    oddCount += number;
//                }
//            }
//        }
//    }
//}

// ===================================================== Lesson - 4 =====================================================

//N ta elementdan iborat 1 o‘lchamli list berilgan. 3 ga va 7 ga karrali elementlarini miqdorini toping.
//using System.Diagnostics.Metrics;

//namespace ListMassive
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("Enter number: ");
//            var sizeArray = int.Parse(Console.ReadLine());
//            var result = FillArray(sizeArray);
//            ThireAndSeven(result);
//        }
//        public static List<int> FillArray(int number)
//        {
//            var collection = new List<int>();

//            for (var i = 0; i < number; i++)
//            {
//                Console.Write($"Array [{i}]: ");
//                var sum = int.Parse(Console.ReadLine());
//                collection.Add(sum);
//            }
//            return collection;
//        }
//        public static void ThireAndSeven(List<int> num)
//        {
//            var count = 0;
//            foreach (var number in num)
//            {
//                if (number % 3 == 0 && number % 7 == 0)
//                {
//                    count++;
//                }
//            }
//            Console.WriteLine(count);
//        }
//    }
//}

// ===================================================== Lesson - 5 =====================================================

//N ta elementdan iborat 1 o‘lchamli list berilgan. 2 xonali toq elementlarini miqdorini va yig‘indisini toping.
//using System.Diagnostics.Metrics;

//namespace ListMassive
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("Enter number: ");
//            var sizeArray = int.Parse(Console.ReadLine());
//            var result = FillArray(sizeArray);
//            int toqSon;
//            int toqSonYegindis;
//            TwoOddNumber(result, out toqSon, out toqSonYegindis);
//            Console.WriteLine($"Toq sonlar yeg;indis: {toqSonYegindis} va toqsonlar nechtaligi: {toqSon}");
//        }
//        public static List<int> FillArray(int num)
//        {
//            var newArray = new List<int>();
//            for (var i = 0; i < num; i++)
//            {
//                Console.WriteLine($"Array[{i}]: ");
//                var number = int.Parse(Console.ReadLine());
//                newArray.Add(number);
//            }
//            return newArray;
//        }
//        public static void TwoOddNumber(List<int> num, out int oddCount, out int sumOfNumber)
//        {
//            oddCount = 0;
//            sumOfNumber = 0;
//            foreach (var number in num)
//            {
//                if (number > 9 && number < 100)
//                {
//                    if (number % 2 == 1)
//                    {
//                        oddCount++;
//                        sumOfNumber += number;
//                    }
//                }
//            }
//        }
//    }
//}

// ===================================================== Lesson - 6 =====================================================

//N ta elementdan iborat 1 o‘lchamli list berilgan. 1 chi va oxirgi elementlarini almashtiring va ekranga listni chiqaring.

namespace ListMassive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            var sizeArray = int.Parse(Console.ReadLine());
            var result = FillArray(sizeArray);
        }
        public static List<int> FillArray(int num)
        {
            var newArray = new List<int>();
            for (var i = 0; i < num; i++)
            {
                Console.WriteLine($"Array [{i}]: ");
                var number = int.Parse(Console.ReadLine());
                newArray.Add(number);
            }
            return newArray;
        }
        public static void FirstArrayLengthEnd(List<int> num, out int firstNumber, out int endNumber)
        {
            firstNumber = num[0];
            endNumber = num[num.Count - 1];
            foreach (var number in num)
            {
                
            }
        }
    }
}
//{
//            var temp = firstInt;
//            firstInt = seccondInt;
//            seccondInt = temp;
//        }