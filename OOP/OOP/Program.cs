namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            Student student = new Student();
            student.Name = "Eldorbek";
            student.Age = "19";
            student.Pol = "Erkak";
            student.Email = "eldorbek@gmail.com";
            student.Gruop = "G10";

            Student NewStudent = new Student()
            {
                Name = "Saidakbar",
                Age = "24",
                Pol = "Erkak",
                Email = "saidakbar@gmail.com",
                Gruop = "G10",
            };

            Student SecondNewStudent = new Student()
            {
                Name = "Nurulloh",
                Age = "25",
                Pol = "Erkak",
                Email = "nurulloh@gmail.com",
                Gruop = "G10",
            };

            Student thirdNewStudent = new Student();
            thirdNewStudent.Name = "IslomBek";
            thirdNewStudent.Age = "19";
            thirdNewStudent.Pol = "Erkak";
            thirdNewStudent.Email = "islombek@gmail.com";
            thirdNewStudent.Gruop = "G10";

            Student EndNewStudent = new Student()
            {
                Name = "Boymurod",
                Age = "24",
                Pol = "Erkak",
                Email = "boyka@gmail.com",
                Gruop = "G10",
            };

            List<Animal> animal = new List<Animal>();

            Animal animalId = new Animal()
            {
                Id = 1,
                Name = "Lion",
                Age = 10,

            };
            List<Book> book = new List<Book>();
            Book bookId = new Book()
            {
                Id = 1,
                Language = "Uzbek",
                Website = "Book.uz"
            };
            List<Computer> comp = new List<Computer>();
            Computer compyuter = new Computer()
            {
                Id = 1,
                Model = "Legion",
                Price = 1500,
            };
            List<Game> game = new List<Game>();
            Game gameOver = new Game()
            {
                Id = 1,
                RAM = 4,
                Developer = "PDP students",
            };
            List<Home> home = new List<Home>();
            Home house = new Home()
            {
                Id = 1,
                Address = "Yunusobod",
                Price = 1200
            };
            List<movie> Tag = new List<movie>();
            movie Tab = new movie()
            {
                Id = 1,
                Language = "English",
                Director = "Ilkhom Tilovov",
            };
            List<Phone> Telefon = new List<Phone>();
            Phone telefon = new Phone()
            {
                Id = 1,
                RAM = 8,
                Color = "Gold",
            };
            List<Planet> planet = new List<Planet>();
            Planet planetId = new Planet()
            {
                Id = 1,
                Type = "Mars",
                Diameter = 60000,
            };
            List<Resturant> rusturand = new List<Resturant>();
            Resturant resurant = new Resturant()
            {
                Id = 1,
                Address = "Yunusobod",
                Name = "Anjir",
            };
            List<School> school = new List<School>();
            School schoolID = new School()
            {
                Id = 1,
                Name = "323",
                TeacherName = "Akobir Teacher"
            };

        }
    }
}
