
// ===================================== Bu Ref bilan ishlangan xolat =====================================
//namespace src
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            var firstNumber = 5;
//            var secondNumber = 15;
//            SwapValues(ref firstNumber, ref secondNumber);
//            Console.WriteLine(firstNumber);
//            Console.WriteLine(secondNumber);
//            Console.WriteLine(firstNumber);
//        }

//        static void print(ref int a)
//        {
//            a = 88;
//        }
//        public static void SwapValues(ref int firstInt, ref int seccondInt)
//        {
//            var temp = firstInt;
//            firstInt = seccondInt;
//            seccondInt = temp;
//        }
//    }
//}
//Agar o‘zgaruvchi qiymatini o‘zgartirmoqchi va u qiymatni qayta ishlatmoqchi bo‘lsangiz – ref.
// ===================================== Bu Out bilan ishlangan xolat =====================================
//namespace src
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int firstNumber;
//            int secondNumber;
//            SwapValues(out firstNumber, out secondNumber);
//            Console.WriteLine(firstNumber);
//            Console.WriteLine(secondNumber);
//        }

//        public static void SwapValues(out int firstInt, out int seccondInt)
//        {
//            firstInt = 5;
//            seccondInt = 6;
//        }
//    }
//}
//Agar funksiya bir nechta qiymat qaytarishi kerak bo‘lsa yoki parametr funksiya ichida qiymat olib, keyin foydalanilishi kerak bo‘lsa – out.


// ====================================== Home Work - 1 ======================================
//Kamida 2ta harfdan iborat satr berilgan. Shu satrni boshidagi va oxiridagi harflarisiz natijani qaytaring.

//withoutEnd("Hello") → "ell"
//withoutEnd("java") → "av"
//withoutEnd("coding") → "odin"


//namespace src
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            string str;
//            withoutEnd(out str);
//            Console.WriteLine(str);
//        }
//        public static void withoutEnd(out string s)
//        {
//            s = "Hello";
//            s = s.Substring(1, s.Length - 2);
//        }

//    }
//}

// ====================================== Home Work - 1 ======================================

//1.helloName
//Name nomli satr berilgan, masalan “Aziz”, ushbu korinishda natijani qaytaring(return qiling): “Hello Aziz!”.

//helloName("Bob") → "Hello Bob!"
//helloName("Alice") → "Hello Alice!"
//helloName("X") → "Hello X!"

//namespace src
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            string hi;
//            string name;
//            helloName(out hi, out name);
//            var helloNames = $"{hi} {name}";
//            Console.WriteLine(helloNames);
//        }
//        public static void helloName(out string hi, out string name)
//        {
//            hi = "Hello";
//            name = "Aziz";

//        }

//    }
//}

// ====================================== Home Work - 2 ======================================



//2.makeAbba
//Ikkita a va b satr berilgan. Natijani abba ketma-ketlikda qaytaring. Masalan, “Hi” va “Bye” satrlar bolsa, natija “HiByeByeHi” bolsin.

//makeAbba("Hi", "Bye") → "HiByeByeHi"
//makeAbba("Yo", "Alice") → "YoAliceAliceYo"
//makeAbba("What", "Up") → "WhatUpUpWhat"


namespace src
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1;
            string str2;
            makeAbba(out str1, out str2);
            string str3 = str1 + str2 + str2 + str1;
            Console.WriteLine(str3);
        }
        public static void makeAbba(out string s1, out string s2)
        {
            s1 = "Hi";
            s2 = "Bye";
        }

    }
}