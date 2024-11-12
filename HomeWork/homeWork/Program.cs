
// ==================================== H O M E W O R K - 1 ====================================
//namespace homeWork
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Stirng kiriting: ");
//            var str = Console.ReadLine();
//            Console.WriteLine(helloName(str));
//        }
//        public static string helloName(string s)
//        {
//            return $"Hello {s}!";
//        }
//    }
//}

// ==================================== H O M E W O R K - 2 ====================================
//namespace homeWork
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Stirng 1 kiriting: ");
//            var s1 = Console.ReadLine();
//            Console.WriteLine("Stirng 2 kiriting: ");
//            var s2 = Console.ReadLine();
//            Console.WriteLine(helloName(s1, s2));
//        }
//        public static string helloName(string s1, string s2)
//        {
//            return s1 + s2 + s2 + s1;
//        }
//    }
//}

// ==================================== H O M E W O R K - 3 ====================================
//namespace homeWork
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Stirng 1 kiriting: ");
//            var s1 = Console.ReadLine();
//            Console.WriteLine("Stirng 2 kiriting: ");
//            var s2 = Console.ReadLine();
//            Console.WriteLine(helloName(s1, s2));
//        }
//        public static string helloName(string s1, string s2)
//        {
//            return s1.Substring(0, s1.Length / 2) + s2 + s1.Substring(s1.Length / 2);
//        }
//    }
//}

// ==================================== H O M E W O R K - 4 ====================================
//namespace homeWork
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Stirng 1 kiriting: ");
//            var s1 = Console.ReadLine();

//            Console.WriteLine(helloName(s1));
//        }
//        public static string helloName(string s1)
//        {
//            return s1.Length > 2 ? s1.Substring(s1.Length - 2) + s1.Substring(s1.Length - 2) + s1.Substring(s1.Length - 2) : s1 + s1 + s1;
//        }
//    }
//}

// ==================================== H O M E W O R K - 5 ====================================
//namespace homeWork
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Stirng 1 kiriting: ");
//            var s1 = Console.ReadLine();

//            Console.WriteLine(helloName(s1));
//        }
//        public static string helloName(string s1)
//        {
//            return s1.Length > 2 ? s1.Substring(0, 2) + s1.Substring(0, 2) + s1.Substring(0, 2) : s1 + s1 + s1;
//        }
//    }
//}

// ==================================== H O M E W O R K - 6 ====================================
//namespace homeWork
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Stirng 1 kiriting: ");
//            var s1 = Console.ReadLine();

//            Console.WriteLine(helloName(s1));
//        }
//        public static string helloName(string s1)
//        {
//            return s1.Length % 2 == 0 ? s1.Substring(0, s1.Length / 2) : "Uzunligi juft emas!";
//        }
//    }
//}

// ==================================== H O M E W O R K - 7 ====================================
//namespace homeWork
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Stirng 1 kiriting: ");
//            var s1 = Console.ReadLine();

//            Console.WriteLine(helloName(s1));
//        }
//        public static string helloName(string s1)
//        {
//            return s1.Length > 3 ? s1.Substring(1, s1.Length - 2) : "Uzunligi 4 dan kichik xolatda malumot chiqara olmaysiz!";
//        }
//    }
//}

// ==================================== H O M E W O R K - 8 ====================================
//namespace homeWork
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Stirng 1 kiriting: ");
//            var s1 = Console.ReadLine();
//            Console.WriteLine("Stirng 1 kiriting: ");
//            var s2 = Console.ReadLine();
//            Console.WriteLine(helloName(s1, s2));
//        }
//        public static string helloName(string s1, string s2)
//        {
//            return s2.Length > s1.Length ? s1 + s2 + s1 : s2 + s1 + s2;
//        }
//    }
//}

// ==================================== H O M E W O R K - 9 ====================================
//namespace homeWork
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Stirng 1 kiriting: ");
//            var s1 = Console.ReadLine();
//            Console.WriteLine("Stirng 1 kiriting: ");
//            var s2 = Console.ReadLine();
//            Console.WriteLine(helloName(s1, s2));
//        }
//        public static string helloName(string s1, string s2)
//        {
//            return s1.Length > 0 && s2.Length > 0 ? s1.Substring(1) + s2.Substring(1) : "string uzunligi 1dan kam!";
//        }
//    }
//}

// ==================================== H O M E W O R K - 10 ====================================
//namespace homeWork
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Stirng 1 kiriting: ");
//            var s1 = Console.ReadLine();

//            Console.WriteLine(helloName(s1));
//        }
//        public static string helloName(string s1)
//        {
//            return s1.Substring(2) + s1.Substring(0, 2);
//        }
//    }
//}

// ==================================== H O M E W O R K - 11 ====================================
//namespace homeWork
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Stirng 1 kiriting: ");
//            var s1 = Console.ReadLine();

//            Console.WriteLine(helloName(s1, true));
//            Console.WriteLine(helloName(s1, false));
//            Console.WriteLine(helloName(s1, true));
//        }
//        public static string helloName(string s1, bool TF)
//        {
//            return TF ? s1.Substring(0, 1) : s1.Substring(s1.Length - 1);
//        }
//    }
//}

// ==================================== H O M E W O R K - 12 ====================================
//namespace homeWork
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Stirng 1 kiriting: ");
//            var s1 = Console.ReadLine();

//            Console.WriteLine(helloName(s1, 1));
//            Console.WriteLine(helloName(s1, 2));
//            Console.WriteLine(helloName(s1, 3));
//        }
//        public static string helloName(string s1, int n)
//        {
//            return s1.Substring(0, n) + s1.Substring(s1.Length - n);
//        }
//    }
//}

// ==================================== H O M E W O R K - 13 ====================================
//namespace homeWork
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Stirng 1 kiriting: ");
//            var s1 = Console.ReadLine();

//            Console.WriteLine(helloName(s1));

//        }
//        public static string helloName(string s1)
//        {
//            return s1.Length % 2 == 1 ? s1.Substring(s1.Length / 2 - 1, 3) : "Juft uzulikdagi Text yozdingiz!";
//        }
//    }
//}

// ==================================== H O M E W O R K - 14 ====================================
//namespace homeWork
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Stirng 1 kiriting: ");
//            var s1 = Console.ReadLine();
//            Console.WriteLine("Stirng 2 kiriting: ");
//            var s2 = Console.ReadLine();
//            Console.WriteLine(helloName(s1, s2));

//        }
//        public static string helloName(string s1, string s2)
//        {
//            return s1.Substring(s1.Length - 1) == s2.Substring(0, 1) ? s1.Substring(0, s1.Length - 1) + s2 : s1 + s2;
//        }
//    }
//}

// ==================================== H O M E W O R K - 15 ====================================
//namespace homeWork
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Stirng 1 kiriting: ");
//            var s1 = Console.ReadLine();

//            Console.WriteLine(helloName(s1));

//        }
//        public static string helloName(string s1)
//        {
//            var LastString = s1.Substring(s1.Length - 1);
//            var secondString = s1.Substring(s1.Length - 2);
//            return s1.Substring(0, s1.Length - 2) + LastString + secondString.Substring(0, 1);
//        }
//    }
//}

// ==================================== H O M E W O R K - 16 ====================================
//namespace homeWork
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Stirng 1 kiriting: ");
//            var s1 = Console.ReadLine();

//            Console.WriteLine(helloName(s1));

//        }
//        public static string helloName(string s1)
//        {
//            var indexRed = s1.IndexOf("red");
//            var indexBlue = s1.IndexOf("blue");
//            return indexBlue == 0 ? s1.Substring(0, 4) : indexRed == 0 ? s1.Substring(0, 3) : "";
//        }
//    }
//}

// ==================================== H O M E W O R K - 17 ====================================
//namespace homeWork
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Stirng 1 kiriting: ");
//            var s1 = Console.ReadLine();

//            Console.WriteLine(helloName(s1));

//        }
//        public static bool helloName(string s1)
//        {
//            return s1.Substring(0, 2) == s1.Substring(s1.Length - 2);
//        }
//    }
//}

// ==================================== H O M E W O R K - 18 ====================================
//namespace homeWork
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Stirng 1 kiriting: ");
//            var s1 = Console.ReadLine();
//            Console.WriteLine("Stirng 2 kiriting: ");
//            var s2 = Console.ReadLine();
//            Console.WriteLine(helloName(s1, s2));

//        }
//        public static string helloName(string s1, string s2)
//        {
//            return s1.Length > s2.Length ? s1.Substring(s1.Length - s2.Length) + s2 : s1 + s2.Substring(s2.Length - s1.Length);
//        }
//    }
//}

// ==================================== H O M E W O R K - 19 ====================================
//namespace homeWork
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Stirng 1 kiriting: ");
//            var s1 = Console.ReadLine();

//            Console.WriteLine(helloName(s1));

//        }
//        public static string helloName(string s1)
//        {
//            return s1.Substring(0, 2) == "ab" ? s1
//                : s1.Substring(0, 1) == "a" ? s1.Substring(0, 1) + s1.Substring(2) : s1.Substring(1, 1) == "b" ? s1.Substring(1) : s1.Substring(2);
//        }
//    }
//}

// ==================================== H O M E W O R K - 20 ====================================
//namespace homeWork
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Stirng 1 kiriting: ");
//            var s1 = Console.ReadLine();

//            Console.WriteLine(helloName(s1));

//        }
//        public static string helloName(string s1)
//        {
//            return s1.Substring(0, 1) == "x" && s1.Substring(s1.Length - 1) == "x" ? s1.Substring(1, s1.Length - 2) :
//                s1.Substring(s1.Length - 1) == "x" ? s1.Substring(0, s1.Length - 1) : s1.Substring(0, 1) == "x" ? s1.Substring(1) : s1;
//        }
//    }
//}

//catDog("catdog") → true
//catDog("catcat") → false
//catDog("1cat1cadodog") → true


// ==================================== H O M E W O R K - 2.1 ====================================
//namespace homeWork
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {


//            Console.WriteLine(helloName("catdog"));
//            Console.WriteLine(helloName("catcat"));
//            Console.WriteLine(helloName("1cat1cadodog"));

//        }
//        public static bool helloName(string s1)
//        {
//            var dog = "dog";
//            var dogCount = 0;
//            var cat = "cat";
//            var catCount = 0;
//            for (var i = 0; i <= s1.Length - 3; i++)
//            {
//                if (s1.Substring(i, dog.Length) == dog) dogCount++;
//                else if (s1.Substring(i, cat.Length) == cat) catCount++;
//            }
//            return dogCount == catCount;
//        }
//    }
//}

// ==================================== H O M E W O R K - 2.2 ====================================
//namespace homeWork
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine(helloName("aaacodebbb"));
//            Console.WriteLine(helloName("codexxcode"));
//            Console.WriteLine(helloName("cozexxcope"));

//        }
//        public static int helloName(string s1)
//        {
//            var code = "co";
//            var dogCount = 0;
//            var codeString = "";
//            for (var i = 0; i <= s1.Length - 4; i++)
//            {
//                if (s1[i] == 'c' && s1[i + 1] == 'o' && s1[i + 3] == 'e')
//                {
//                    dogCount++;
//                }
//            }
//            return dogCount;
//        }
//    }
//}

// ==================================== H O M E W O R K - 2.3 ====================================
//namespace homeWork
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine(helloName("Hiabc", "abc"));
//            Console.WriteLine(helloName("AbC", "HiaBcs"));
//            Console.WriteLine(helloName("abc", "abXabc"));

//        }
//        public static bool helloName(string s1, string s2)
//        {
//            s1 = s1.ToLower();
//            s2 = s2.ToLower();
//            return s1.Length > s2.Length ? s1.EndsWith(s2) : s2.EndsWith(s1);
//        }
//    }
//}

// ==================================== H O M E W O R K - 2.4 ====================================
//namespace homeWork
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine(helloName("abcxyz"));
//            Console.WriteLine(helloName("Aabc.xyzbC"));
//            Console.WriteLine(helloName("xyz.abc"));
//            Console.WriteLine(helloName("abc.xyzxyz"));
//        }
//        public static bool helloName(string s1)
//        {
//            var TF = false;
//            for (var i = 0; i <= s1.Length - 3; i++)
//            {
//                if (s1.Substring(i, 3) == "xyz")
//                {
//                    if (i == 0 || s1[i - 1] != '.')
//                    {
//                        TF = true;
//                    }
//                }
//            }
//            return TF;
//        }
//    }
//}

// ==================================== H O M E W O R K - 2.5 ====================================
//namespace homeWork
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine(helloName("abc", "xyz"));
//            Console.WriteLine(helloName("Hi", "There"));
//            Console.WriteLine(helloName("xxxx", "There"));
//        }
//        public static string helloName(string s1, string s2)
//        {
//            string counter = "";

//            for (var i = 0; i < Math.Max(s1.Length, s2.Length); i++)
//            {
//                if (s1.Length > i)
//                {
//                    counter += s1[i];
//                }
//                if (s2.Length > i)
//                {
//                    counter += s2[i];
//                }
//            }
//            return counter;
//        }
//    }
//}

// ==================================== H O M E W O R K - 2.6 ====================================
//namespace homeWork
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine(helloName("Hello", 3));
//            Console.WriteLine(helloName("Hello", 2));
//            Console.WriteLine(helloName("Hello", 1));
//        }
//        public static string helloName(string s1, int n)
//        {
//            var text = "";
//            s1 = s1.Substring(s1.Length - n);
//            for (var i = 0; i < n; i++)
//            {
//                text += s1;
//            }

//            return text;
//        }
//    }
//}

// ==================================== H O M E W O R K - 2.7 ====================================
//namespace homeWork
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine(helloName("Chocolate", 4));
//            Console.WriteLine(helloName("Chocolate", 3));
//            Console.WriteLine(helloName("Ice Cream", 2));
//        }
//        public static string helloName(string s1, int n)
//        {
//            var text = "";

//            for (var i = 0; i < n; i++)
//            {
//                text += s1.Substring(0, n - i);

//            }

//            return text;
//        }
//    }
//}

// ==================================== H O M E W O R K - 2.8 ====================================
//namespace homeWork
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine(helloName("Word", "X", 3));
//            Console.WriteLine(helloName("This", "And", 2));
//            Console.WriteLine(helloName("This", "And", 1));
//        }
//        public static string helloName(string s1, string s2, int n)
//        {
//            var text = s1 + s2;
//            var str = "";
//            for (var i = 0; i < n; i++)
//            {
//                str += text;

//            }

//            return str.Substring(0, str.Length - s2.Length);
//        }
//    }
//}


// ==================================== H O M E W O R K - 2.9 ====================================
//namespace homeWork
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine(helloName("abXYabc", 3));
//            Console.WriteLine(helloName("abXYabc", 2));
//            Console.WriteLine(helloName("abXYbc", 1));
//        }
//        public static bool helloName(string s1, int n)
//        {
//            var textStr1 = s1.Substring(0, n);
//            var lastIndex = s1.IndexOf(textStr1, n);
//            if (lastIndex == -1)
//            {
//                return false;
//            }
//            var textStr2 = s1.Substring(lastIndex, n);
//            return textStr1 == textStr2;
//        }
//    }
//}

// ==================================== H O M E W O R K - 2.10 ====================================
//namespace homeWork
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine(helloName("breadjambread"));
//            Console.WriteLine(helloName("xxbreadjambreadyy"));
//            Console.WriteLine(helloName("xxbreadyy"));
//        }
//        public static string helloName(string s1)
//        {

//            var breadText = "bread";
//            var startIndex = s1.IndexOf(breadText);
//            var lastIndex = s1.LastIndexOf(breadText);
//            if (startIndex == -10)
//            {
//                return "";
//            }
//            return s1.Substring(startIndex + breadText.Length, lastIndex - breadText.Length - s1.Length);
//        }
//    }
//}

// ==================================== H O M E W O R K - 2.12 ====================================
//namespace homeWork
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine(helloName("xy*yzz"));
//            Console.WriteLine(helloName("xy*zzz"));
//            Console.WriteLine(helloName("*xa*az"));
//        }
//        public static bool helloName(string s)
//        {
//            var index = s.IndexOf("*", 1);
//            return s.Substring(index - 1, 1) == s.Substring(index + 1, 1);
//        }
//    }
//}
//sameStarChar("xy*yzz") → true
//sameStarChar("xy*zzz") → false
//sameStarChar("*xa*az") → true


//==================================== H O M E W O R K - 2.13 ====================================
//namespace homeWork
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine(helloName("zipXzap"));
//            Console.WriteLine(helloName("zopzop"));
//            Console.WriteLine(helloName("zzzopzop"));
//        }
//        public static string helloName(string str)
//        {
//            var stirng = "";
//            for (var i = 0; i < str.Length; i++)
//            {
//                stirng += str[i];
//                if (stirng[i] == 'z' && stirng[i + 2] == 'p')
//                {
//                    stirng = stirng.Remove(i + 1, 1);
//                }
//            }
//            return stirng;
//        }
//    }
//}

//==================================== H O M E W O R K - 2.14 ====================================
//namespace homeWork
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine(helloName("12xy34", "xy"));
//            Console.WriteLine(helloName("12xy34", "1"));
//            Console.WriteLine(helloName("12xy34xyabcxy", "xy"));
//        }
//        public static string helloName(string s1, string s2)
//        {
//            var str = "";
//            var indexS2 = s1.IndexOf(s2);
//            for (var i = 0; i <= s1.Length - s2.Length; i++)
//            {
//                if (s1.Substring(i, s2.Length) == s2)
//                {
//                    str += s2;
//                }
//                else
//                {
//                    str += "+";
//                }
//            }
//            return str;
//        }
//    }
//}

//==================================== H O M E W O R K - 2.15 ====================================
//namespace homeWork
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine(helloName("abcXY123XYijk", "XY"));
//            Console.WriteLine(helloName("XY123XY", "XY"));
//            Console.WriteLine(helloName("XY1XY", "XY"));
//        }
//        public static string helloName(string s1, string s2)
//        {
//            var str = "";
//            for (var i = 0; i <= s1.Length - s2.Length; i++)
//            {
//                if (s1.Substring(i, s2.Length) == s2)
//                {
//                    if (i > 0)
//                    {
//                        str += s1[i - 1];
//                    }
//                    if (i + s2.Length < s1.Length)
//                    {
//                        str += s1[i + 2];
//                    }
//                }

//            }
//            return str;
//        }
//    }
//}

//==================================== H O M E W O R K - 3.1 ====================================
//namespace homeWork
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine(CountXY("fez day"));
//            Console.WriteLine(CountXY("day fez"));
//            Console.WriteLine(CountXY("!!day--yaz!!"));
//        }
//        public static int CountXY(string str)
//        {
//            var spaceSign = 0;
//            str += spaceSign;

//            var counter = 0;

//            for (var i = 0; i < str.Length - 1; i++)
//            {
//                if (str[i] == 'z' || str[i] == 'Z' || str[i] == 'y' || str[i] == 'Y')
//                {
//                    if (Char.IsLetter(str[i + 1]) is false)
//                    {
//                        counter++;
//                    }
//                }
//            }
//            return counter;
//        }

//    }
//}

//==================================== H O M E W O R K - 3.3 ====================================
namespace homeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(EqualIsNot("This is not"));
            Console.WriteLine(EqualIsNot("This is notnot"));
            Console.WriteLine(EqualIsNot("noisxxnotyynotxisi"));
        }
        public static bool EqualIsNot(string s1)
        {
            string[] arrr1 = s1.Split("is");
            string[] arr2 = s1.Split("not");

            return arrr1.Length == arr2.Length;
        }
    }
}

//equalIsNot("This is not") → false
//equalIsNot("This is notnot") → true
//equalIsNot("noisxxnotyynotxisi") → true

//==================================== H O M E W O R K - 3.4 ====================================
//namespace homeWork
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine(EqualIsNot("This is not"));
//            Console.WriteLine(EqualIsNot("This is notnot"));
//            Console.WriteLine(EqualIsNot("noisxxnotyynotxisi"));
//        }
//        public static bool EqualIsNot(string s1)
//        {
//            var countNot = 0;
//            var countIs = 0;
//            for (var i = 0; i < s1.Length - 2; i++)
//            {
//                if (s1.Substring(i, 3) == "not")
//                {
//                    countNot++;
//                }
//                if (s1.Substring(i, 2) == "is")
//                {
//                    countIs++;
//                }
//            }


//            return countIs == countNot;
//        }
//    }
//}
