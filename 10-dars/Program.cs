namespace _10_dars;

internal class Program
{
    static void Main(string[] args)
    {

        //1
        //Family Family2 = new Family();
        //{
        //    Family2.GrandFather = "Ubaydullo";
        //    Family2.GrandMother = "Odinaxon";
        //    Family2.Father = "Habibullo";
        //    Family2.Mother = "Zulhumorxon";
        //    Family2.Brother = "Xamidullo";
        //    Family2.IAm = "Hadyatullo";
        //}
        //Family family2 = new Family()
        //{
        //    GrandFather = "Ubaydullo",
        //    GrandMother = "Odinaxon",
        //    Father = "Habibullo",
        //    Mother = "Zulhumorxon",
        //    Brother = "Xamidullo",
        //    IAm = "Hadyatullo"
        //};
        //Console.WriteLine(Family2.Father);
        //Console.WriteLine(family2.Mother);


        //2
        //Book book = new Book();
        //{
        //    book.Title = "Sherlok Holms";
        //    book.Author = "Artur Konan Doyl";
        //    book.Genre = "Detektiv";
        //    book.Publisher = "O‘zbekiston Nashriyoti";
        //    book.ISBN = "1234567890";
        //}
        //Book book2 = new Book()
        //{
        //    Title = "Alkimyogar",
        //    Author = "Paulo Koelyo",
        //    Genre = "Roman",
        //    Publisher = "Adabiyot Nashriyoti",
        //    ISBN = "0987654321"
        //};
        //Console.WriteLine(book.Title);
        //Console.WriteLine(book2.Author);


        //3
        //Phone phone1 = new Phone();
        //{
        //    phone1.Brand = "Apple";
        //    phone1.Model = "iPhone 13";
        //    phone1.Color = "Oq";
        //    phone1.Storage = "128GB";
        //    phone1.OperatingSystem = "iOS";
        //}
        //Phone phone2 = new Phone()
        //{
        //    Brand = "Samsung",
        //    Model = "Galaxy S21",
        //    Color = "Qora",
        //    Storage = "256GB",
        //    OperatingSystem = "Android"
        //};
        //Console.WriteLine(phone2.Brand);
        //Console.WriteLine(phone2.Model);


        //4
        //Student student1 = new Student();
        //{
        //    student1.Name = "Arslonbek";
        //    student1.Surname = "Egamberdiyev";
        //    student1.StudentID = "1BK12345";
        //    student1.Major = "Tarmoq adminstratori";
        //    student1.Year = "3";
        //}
        //Student student2 = new Student()
        //{
        //    Name = "Gulbahor",
        //    Surname = "Karimova",
        //    StudentID = "1BK67890",
        //    Major = "Matematika",
        //    Year = "2"
        //};
        //Console.WriteLine(student1.Name);
        //Console.WriteLine(student2.Major);


        //5
        Uzbekistan uz1 = new Uzbekistan();
        {
            uz1.CountryName = "O'zbekiston";
            uz1.Capital = "Toshkent";
            uz1.Population = 38000000;
            uz1.RegionCount = 12;
            uz1.LargestRegion = "Navoiy viloyati";
        }
        Uzbekistan uz2 = new Uzbekistan()
        {
            CountryName = "O'zbekiston",
            Capital = "Toshkent",
            Population = 38000000,
            RegionCount = 12,
            LargestRegion = "Navoiy viloyati"
        };
        Console.WriteLine(uz2.LargestRegion);
        Console.WriteLine(uz1.Population);
    }
}
