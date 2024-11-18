namespace CRUD
{
    internal class Program
    {
        public static List<string> ServerHouse = new List<string>();
        static void Main(string[] args)
        {
            StartProgram();
        }
        public static void StartProgram()
        {
            while (true)
            {

                Console.WriteLine("1. Ma'lumot qo'shish.");
                Console.WriteLine("2. Ma'lumot o'chirish.");
                Console.WriteLine("3. Ma'lumot to'liq o'zgartirish.");
                Console.WriteLine("4. Ma'lumot o'zgartirish.");
                Console.WriteLine("5. Ma'lumot ko'rish.");
                Console.Write("Choose: ");
                var option = int.Parse(Console.ReadLine());


                if (option == 1)
                {
                    Console.Clear();
                    NameSurnameAdd();
                }
                else if (option == 2)
                {
                    InfoDelete();

                }
                else if (option == 3)
                {
                    IndexUpdate();
                }
                else if (option == 4)
                {
                    UpDateServer();
                }
                else if (option == 5)
                {
                    DisplayInfo();
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
        public static void NameSurnameAdd()
        {

            string str = "";
            Console.Write("Ism kiriting: ");
            var name = Console.ReadLine();
        StartAge:
            Console.Write("Yoshni kiriting: ");
            string age = Console.ReadLine();
            if (!Age(ref age))
            {
                Console.Write("Shu yoshga yetib yurish nasib qilsin");
                goto StartAge;
            }
        StartPhone:
            Console.Write("Telefon raqamni kiriting: ");
            string phoneNumber = Console.ReadLine();

            if (!PhoneNumber(ref phoneNumber))
            {
                Console.WriteLine("Kiritilgan raqaimingiz notori!");
                goto StartPhone;
            }
            Console.Write("Manzilni kiritin: ");
            string adress = Console.ReadLine();
            str += "Ism: " + name + ", Yosh: " + age + ", Telefon raqam: "
                + phoneNumber + ", Manzil: " + adress;
            ServerHouse.Add(str);
            Console.WriteLine("\nMa'lumotingiz muvafaqiyatli yuklandi.");
            Console.WriteLine("Iltimos Enter tugmasini bosing.");
        }

        public static void InfoDelete()
        {
            DisplayInfo();
            Console.Write("Qaysi qatordagi malumotni o'chirmoqchisiz: ");
            var index = int.Parse(Console.ReadLine()) - 1;
            if (ServerHouse.Count > index)
            {
                ServerHouse.RemoveAt(index);
                Console.WriteLine("\nMalumotingiz o'chirildi.");
                Console.WriteLine("Iltimos Enter tugmasini bosing.");
            }
            else
            {
                Console.WriteLine("Bu qatorda malumot mavjud emas");
            }
        }
        public static void DisplayInfo()
        {
            for (var i = 0; i < ServerHouse.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {ServerHouse[i]}.");
            }
            Console.WriteLine("\nEnter tugmasini bosing!");
        }
        public static void UpDateServer()
        {
            DisplayInfo();
            Console.Write("Qaysi qatordagi malumotni o'zgartirmoqchisiz: ");
            var index = int.Parse(Console.ReadLine()) - 1;
            Console.WriteLine("1. Ism familiya: ");
            Console.WriteLine("2. Yosh: ");
            Console.WriteLine("3. Telefon raqamni: ");
            Console.WriteLine("4. Manzilni kiritin: ");
            var choise = int.Parse(Console.ReadLine());
            string[] nameIndex = ServerHouse[index].Split(",");
            switch (choise)
            {
                case 1:
                    Console.Write("Ism familiya kiriting: ");
                    var newNameSurname = Console.ReadLine();
                    nameIndex[0] = nameIndex[0].Replace(nameIndex[0].Substring(5), newNameSurname);
                    ServerHouse[index] = string.Join(",", nameIndex);
                    break;
                case 2:
                    Console.Write("Yoshni kiriting: ");
                    var newAge = Console.ReadLine();
                    nameIndex[1] = nameIndex[1].Replace(nameIndex[1].Substring(7), newAge);
                    ServerHouse[index] = string.Join(",", nameIndex);
                    break;
                case 3:
                    Console.Write("Yangi telefon raqam kiriting: ");
                    var newPhoneNuber = Console.ReadLine();
                    nameIndex[2] = nameIndex[2].Replace(nameIndex[2].Substring(10), newPhoneNuber);
                    ServerHouse[index] = string.Join(",", nameIndex);
                    break;
                case 4:
                    Console.Write("Yangi telefon raqam kiriting: ");
                    var newAdress = Console.ReadLine();
                    nameIndex[3] = nameIndex[3].Replace(nameIndex[3].Substring(9), newAdress);
                    ServerHouse[index] = string.Join(",", nameIndex);
                    break;
            }
        }
        public static void IndexUpdate()
        {
            DisplayInfo();
            Console.Write("Qaysi qatordagi malumotni o'zgartirmoqchisiz: ");
            var index = int.Parse(Console.ReadLine()) - 1;
            ServerHouse.RemoveAt(index);
            NameSurnameAdd();
        }
        public static bool PhoneNumber(ref string phone)
        {
            if (!phone.StartsWith("+998"))
            {
                return false;
            }
            else if (phone.Length != 13)
            {
                return false;
            }
            for (var i = 4; i < phone.Length; i++)
            {
                if (!Char.IsDigit(phone[i]))
                {
                    return false;
                }
            }
            return true;
        }
        public static bool Age(ref string age)
        {
            var ageInt = int.Parse(age);
            if (ageInt >= 0 && ageInt <= 99)
            {
                for (var i = 0; i < age.Length; i++)
                {
                    if (!Char.IsDigit(age[i]))
                    {
                        return false;
                    }
                }
            }
            else
            {
                return false;
            }
            return true;
        }
    }
}


//// 1 ism familiya
//// 2 yoshi 
//// 3 telefon raqami
//// 4 adress


//namespace CRUD
//{
//    internal class Program
//    {
//        public static List<string> MainServer = new List<string>();
//        static void Main(string[] args)
//        {
//            MainBody();
//        }
//        public static void MainBody()
//        {
//            while (true)
//            {
//                Console.WriteLine("1. Add serie");
//                Console.WriteLine("2. Delete serie");
//                Console.WriteLine("3. Update serie");
//                Console.WriteLine("4. Read serie");
//                Console.Write("Choose: ");
//                var option = int.Parse(Console.ReadLine());
//                if (option == 1)
//                {
//                    Console.Write("Added new serie: ");
//                    var addPassport = Console.ReadLine();
//                    var index = AddPasport(addPassport);
//                    if (index == -1)
//                    {
//                        Console.WriteLine("Not added, error occured");
//                    }
//                    else
//                    {
//                        Console.WriteLine($"Addec, successed index {index}");
//                    }
//                }
//                else if (option == 2)
//                {
//                    Console.Write("Enter delete serie: ");
//                    var deleteSerie = Console.ReadLine();
//                    var boolResult = DeleteSerie(deleteSerie);
//                    if (boolResult is true)
//                    {
//                        Console.WriteLine("Deleted, successed");
//                    }
//                    else
//                    {
//                        Console.WriteLine("Not delete, error occured");
//                    }
//                }
//                else if (option == 3)
//                {
//                    Console.WriteLine("Enter oldUpdate serie: ");
//                    var oldSerie = Console.ReadLine();
//                    Console.WriteLine("Enter newUpdate serie");
//                    var newSerie = Console.ReadLine();
//                    var boolResult = UpdateSerie(oldSerie, newSerie);
//                    if (boolResult is true)
//                    {
//                        Console.WriteLine("Deleted, successed");
//                    }
//                    else
//                    {
//                        Console.WriteLine("Not delete, error occured");
//                    }
//                }
//                else if (option == 4)
//                {
//                    var series = MainServerRead();
//                    foreach (var serie in series)
//                    {
//                        Console.WriteLine(serie);
//                    }
//                }
//                Console.ReadKey();
//                Console.Clear();
//            }


//        }
//        public static int AddPasport(string serie)
//        {
//            var exists = MainServer.Contains(serie);
//            if (exists is true)
//            {
//                return -1;
//            }
//            MainServer.Add(serie);
//            return MainServer.Count - 1;
//        }
//        public static bool DeleteSerie(string serie)
//        {
//            var exists = MainServer.Contains(serie);
//            MainServer.Remove(serie);
//            return exists;
//        }
//        public static bool UpdateSerie(string oldSerie, string newSerie)
//        {
//            var index = MainServer.IndexOf(oldSerie);
//            var boolResult = false;
//            if (index >= 0)
//            {
//                MainServer[index] = newSerie;
//                boolResult = true;
//            }
//            return boolResult;
//        }
//        public static List<string> MainServerRead()
//        {
//            return MainServer;
//        }
//    }
//}