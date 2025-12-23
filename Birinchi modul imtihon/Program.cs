namespace Birinchi_modul_imtihon;

internal class Program
{
    //1

    //static void Main(string[] args)
    //{
    //    List<int> list = new List<int> { 2, 9, 56, 33, 115, 984 };
    //    var res = CountJuft(list);
    //    Console.WriteLine(res);
    //}
    //static int CountJuft(List<int> list)
    //{
    //    var count = 0;
    //    foreach (var n in list)
    //    {
    //        if (n % 2 == 0)
    //        {
    //            count++;
    //        }
    //    }
    //    return count;
    //}

    //2
    static void Main(string[] args)
    {
        List<string> list = new List<string> { "olma", "shaftoli", "anorra", "apelsin", "ananas" };
        var res = Checking(list);
        Console.WriteLine(res);
    }
    static bool Checking(List<string> str)
    {
        foreach(string s in str)
        {
            if(s.Length <= 5)
            {
                return false;
            }
        }
        return true;
    }

    //3
    //static void Main(string[] args)
    //{
    //    Console.Write("Satirni kirit : ");
    //    var texts = Console.ReadLine();
    //    var res = Qaytar(texts);
    //    Console.WriteLine(res);
    //}
    //static string Qaytar(string str)
    //{
    //    var s = str.Substring(0, 3);
    //    return s;
    //}

    //4
    //static void Main(string[] args)
    //{
    //    Console.Write("satir kirit : ");
    //    var text = Console.ReadLine();
    //    var s = PdpChecking(text);
    //    Console.WriteLine(s);
    //}
    //static bool PdpChecking(string str)
    //{
    //    var res = str.StartsWith("PDP");
    //    return res;
    //}

    //5
    //static void Main(string[] args)
    //{
    //    Console.Write("satrni kirit : ");
    //    var text = Console.ReadLine();
    //    var s = G13Checking(text);
    //    Console.WriteLine(s);
    //}
    //static bool G13Checking(string str)
    //{
    //    var res = str.EndsWith("G13");
    //    return res;
    //}

    //6
    //static void Main(string[] args)
    //{
    //    List<int> list = new List<int> { 2, 9, 56, 33, 115, 984 };
    //    var res = TwoSum(list);
    //    Console.WriteLine(res);
    //}
    //static int TwoSum(List<int> list)
    //{
    //    var sum = list[0] + list[1];
    //    return sum;
    //}

}
