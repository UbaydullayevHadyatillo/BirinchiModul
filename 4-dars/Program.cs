namespace _4_dars
{
    internal class Program
    {
        //1
        //static void Main(string[] args)
        //{
        //    var res = Add();
        //    Console.Write(res);
        //}
        //static int Add()
        //{
        //    Console.Write(" 1-sonni kiriting : ");
        //    var num1 = int.Parse(Console.ReadLine());
        //    Console.Write(" 2-sonni kiriting : ");
        //    var num2 = int.Parse(Console.ReadLine());
        //    return num1 + num2;
        //}

        //2
        //static void Main(string[] args)
        //{
        //    Console.Write("text krting : ");
        //    string s = Console.ReadLine();
        //    Console.Write(Alishtirish(s));
        //}
        //static string Alishtirish(string str)
        //{
        //    char[] arr = str.ToCharArray();
        //    for (var i = 0; i < arr.Length; i++)
        //    {
        //        if (arr[i] == 'x')
        //        {
        //            arr[i] = 'y';
        //        }
        //        else if (arr[i] == 'y')
        //        {
        //            arr[i] = 'z';
        //        }
        //    }
        //    return new string(arr);
        //}

        //3
        //static void Main(string[] args)
        //{
        //    Console.Write("text krting : ");
        //    string s = Console.ReadLine();
        //    Console.Write(Count(s));
        //}
        //static int Count(string str)
        //{
        //    int count = 0;
        //    for (var i = 0; i < str.Length; i++)
        //    {
        //        if (char.IsLower(str[i]))
        //        {
        //            count++;
        //        }
        //    }
        //    return count;
        //}

        //4
        //static void Main(string[] args)
        //{
        //    var res = Count();
        //    Console.Write(res);
        //}
        //static int Count()
        //{
        //    Console.WriteLine("Birinchi son ikkichi sondan kichik bolishi shart !!!");
        //    Console.Write(" Birinchi sonni kiriting : ");
        //    var num1 = int.Parse(Console.ReadLine());
        //    Console.Write(" Ikkinchi sonni kiriting : ");
        //    var num2 = int.Parse(Console.ReadLine());
        //    var count = 0;
        //    if (num1 < num2)
        //    {
        //        for (var i = num1; i <= num2; i++)
        //        {
        //            if (i % 2 != 0)
        //            {
        //                count++;
        //            }
        //        }
        //    }
        //    return count;
        //}

        //5
        //static void Main(string[] args)
        //{
        //    var res = Count();
        //    Console.Write($"{res} xonali son");
        //}
        //static int Count()
        //{
        //    Console.Write("son krting : ");
        //    var num = int.Parse(Console.ReadLine());
        //    int count = 0;
        //    while(num > 0)
        //    {
        //        num = num / 10;
        //        count++;
        //    }
        //    return count;
        //}

        //6
        //static void Main(string[] args)
        //{
        //    Console.Write("satirni kiriting : ");
        //    string s = Console.ReadLine();
        //    bool res = Checking(s);
        //    Console.WriteLine(res);
        //}
        //static bool Checking(string str)
        //{
        //    for (var i = 0; i < str.Length; i++)
        //    {
        //        if (!char.IsDigit(str[i]))
        //        {
        //            return false;
        //        }
        //    }
        //    return true;
        //}

        //7
        //static void Main(string[] args)
        //{
        //    Console.WriteLine(PrimeCheck());
        //}
        //static bool PrimeCheck()
        //{
        //    Console.Write("sonni kiriting : ");
        //    var num = int.Parse(Console.ReadLine());
        //    var count = 0;
        //    for(var i = 1; i <= num; i++)
        //    {
        //        if(num % i == 0)
        //        {
        //            count++;
        //        }
        //    }
        //    if (count != 2)
        //    {
        //        return false;
        //    }
        //    return true;
        //}

        //8
        //static void Main(string[] args)
        //{
        //    Console.Write(" satirni kiriting : ");
        //    string res = Console.ReadLine();
        //    Console.WriteLine(Reverse(res));
        //}
        //static string Reverse(string str)
        //{
        //    string s = "";
        //    for (var i = 0; i < str.Length; i++)
        //    {
        //        s = str[i] + s;
        //    }
        //    return s;
        //}

        //9
        //static void Main(string[] args)
        //{
        //    Console.Write(" satirni kiriting : ");
        //    string s = Console.ReadLine();
        //    Console.WriteLine(Spacelar(s));
        //}
        //static int Spacelar(string str)
        //{
        //    var count = 0;
        //    for (int i = 0; i < str.Length; i++)
        //    {
        //        if (str[i] == ' ')
        //        {
        //            count++;
        //        }
        //    }
        //    return count;
        //}

        //10
        //static void Main(string[] args)
        //{
        //    Console.WriteLine(" satirni kiriting : ");
        //    string s = Console.ReadLine();
        //    Console.WriteLine(Palindirom(s));
        //}
        //static bool Palindirom(string str)
        //{
        //    string s = "";
        //    for (var i = 0; i < str.Length; i++)
        //    {
        //        s = str[i] + s;
        //    }
        //    if (s == str)
        //    {
        //        return true;
        //    }
        //    return false;
        //}

        //11
        //static void Main(string[] args)
        //{
        //    Console.Write(" satirni kiriting  : ");
        //    string s = Console.ReadLine();
        //    Console.WriteLine(IsDigit(s));
        //}
        //static bool IsDigit(string str)
        //{
        //    for(var i = 0; i < str.Length; i++)
        //    {
        //        if(!char.IsDigit(str[i]))
        //        {
        //            return false;
        //        }
        //    }
        //    return true;
        //}

        //12
        //static void Main(string[] args)
        //{
        //    Console.Write("Satirni kiriting : ");
        //    string s = Console.ReadLine();
        //    Console.WriteLine(Count(s));
        //}
        //static int Count(string str)
        //{
        //    var count = 0;
        //    for(var i = 0; i < str.Length; i++)
        //    {
        //        if(char.IsDigit(str[i]))
        //        {
        //            count++;
        //        }
        //    }
        //    return count;
        //}

        //13
        //static void Main(string[] args)
        //{
        //    Console.Write("Satirni kiritng : ");
        //    string s = Console.ReadLine();
        //    Console.WriteLine(Miqdor(s));
        //}
        //static int Miqdor(string str)
        //{
        //    var count = 0;
        //    for(var i = 0; i < str.Length; i++)
        //    {
        //        if(char.IsUpper(str[i]))
        //        {
        //            count++;
        //        }
        //    }
        //    return count;
        //}

        //14
        //static void Main(string[] args)
        //{
        //    Console.Write("Satirni kiritng : ");
        //    string s = Console.ReadLine();
        //    Console.WriteLine(Checking(s));
        //}
        //static bool Checking(string str)
        //{
        //    for(var i =  0; i < str.Length; i++)
        //    {
        //        if(!char.IsUpper(str[i]))
        //        {
        //            return false;
        //        }
        //    }
        //    return true;
        //}

        //15
        //static void Main(string[] args)
        //{
        //    Console.Write("Satirni kiritng : ");
        //    string s = Console.ReadLine();
        //    Console.WriteLine(Checking(s));
        //}
        //static bool Checking(string str)
        //{
        //    for (var i = 0; i < str.Length; i++)
        //    {
        //        if (!char.IsLower(str[i]))
        //        {
        //            return false;
        //        }
        //    }
        //    return true;
        //}

        //16
        //static void Main(string[] args)
        //{
        //    Console.Write(" Satirni kiriting : ");
        //    string s = Console.ReadLine();
        //    Console.WriteLine(Swap(s));
        //}
        //static string Swap(string str)
        //{
        //    return str.ToUpper();
        //}

        //17
        //static void Main(string[] args)
        //{
        //    Console.Write("Satrni kiriting : ");
        //    string s = Console.ReadLine();
        //    Console.WriteLine(Conculet(s));
        //}
        //static int Conculet(string str)
        //{
        //    var count = 0;
        //    for(var i = 0; i < str.Length; i++)
        //    {
        //        if (str[i]== 'o' && str[i+1] == 'k')
        //        {
        //            count++;
        //        }
        //    }
        //    return count;
        //}

        //18
        //static void Main(string[] args)
        //{
        //    Console.WriteLine(" satirni kiriting : ");
        //    string s = Console.ReadLine();
        //    Console.Write(Swap(s));
        //}
        //static string Swap(string str)
        //{
        //    var s = "";
        //    for(var i = 0; i < str.Length; i++)
        //    {
        //        if (char.IsLower(str[i]))
        //        {
        //            s = s + '*';
        //        }
        //        else
        //        {
        //            s = s + str[i];
        //        }
        //    }
        //    return s;
        //}

        //19
        //static void Main(string[] args)
        //{
        //    Console.Write("Satirni kiriting : ");
        //    string s = Console.ReadLine();
        //    Console.WriteLine(Swap(s));
        //}
        //static string Swap(string str)
        //{
        //    return str.ToLower();
        //}

        //20
        //static void Main(string[] args)
        //{
        //    Console.Write(" Satirni qoshing : ");
        //    string s = Console.ReadLine();
        //    Console.WriteLine(Swap(s));
        //}
        //static string Swap(string str)
        //{
        //    return str.ToUpper();
        //}

        //21
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("satirni kiriting : ");
        //    string s = Console.ReadLine();
        //    Console.WriteLine(Conculate(s));
        //}
        //static int Conculate(string str)
        //{
        //    var count = 0;
        //    for (var i = 0; i < str.Length; i++)
        //    {
        //        if(str[i] == '@')
        //        {
        //            count++;
        //        }
        //    }
        //    return count;
        //}
        //////////////////////////////////////////1.4.1///////////////

        //1
        //static void Main(string[] args)
        //{
        //    Console.Write("siz kimsiz : ");
        //    string s = Console.ReadLine();
        //    Console.WriteLine(HelloName(s));
        //}
        //static string HelloName(string str)
        //{
        //    return "Hello " + str+"!!";
        //}

        //2
        //static void Main(string[] args)
        //{
        //    Console.Write("birinchi satir : ");
        //    string a = Console.ReadLine();
        //    Console.Write("ikkinchi satir : ");
        //    string b = Console.ReadLine();
        //    string res = MakeAbba(a, b);
        //    Console.WriteLine(res);
        //}
        //static string MakeAbba(string a, string b)
        //{
        //    return a + b + b + a;
        //}

        //3
        //static void Main(string[] args)
        //{
        //    Console.Write("a satirni kiriting(satir uzunligi 4 ga teng !!) :");
        //    var a = Console.ReadLine();
        //    Console.Write("b satirni kiriting : ");
        //    var b = Console.ReadLine();
        //    var res = MakeOutWord(a, b);
        //    Console.Write(res);
        //}
        //static string MakeOutWord(string a, string b)
        //{
        //    var str = a.Substring(0, 2) + b + a.Substring(2, 2);
        //    return str;
        //}

        //4
        //static void Main(string[] args)
        //{
        //    Console.Write(" kamida 2 ta belgili satir kiriting : ");
        //    var s = Console.ReadLine();
        //    var res = ExtraEnd(s);
        //    Console.WriteLine(res);
        //}
        //static string ExtraEnd(string str)
        //{
        //    var s = str.Substring(str.Length - 2);
        //    return s + s + s;
        //}

        //5
        //static void Main(string[] args)
        //{
        //    Console.Write(" Satirni kiriitn : ");
        //    var s = Console.ReadLine();
        //    var res = FirstTwo(s);
        //    Console.WriteLine(res);
        //}
        //static string FirstTwo(string str)
        //{
        //    var s = str.Substring(0, 2);
        //    //if (str.Length == 2)
        //    //{
        //    //    return str;
        //    //}
        //    return s;
        //}

        //6
        //static void Main(string[] args)
        //{
        //    Console.Write("Juf uzunlikdagi satir : ");
        //    var s = Console.ReadLine();
        //    var res = FirstHalf(s);
        //    Console.WriteLine(res);
        //}
        //static string FirstHalf(string str)
        //{
        //    var s = str.Substring(0,str.Length / 2);
        //    return s;
        //}

        //7
        //static void Main(string[] args)
        //{
        //    Console.Write(" kamida ikta harf kiriting : ");
        //    var s = Console.ReadLine();
        //    var res = WithoutEnd(s);
        //    Console.WriteLine(res);
        //}
        //static string WithoutEnd(string str)
        //{
        //    var s = str.Substring(1, str.Length - 2);
        //    return s;
        //}

        //8
        //static void Main(string[] args)
        //{
        //    Console.Write("1-satirni kiriting : ");
        //    var a = Console.ReadLine();
        //    Console.Write("2-satirni kiriting : ");
        //    var b = Console.ReadLine();
        //    var res = ComboString(a, b);
        //    Console.WriteLine(res);
        //}
        //static string ComboString(string a, string b)
        //{
        //    if(a.Length > b.Length)
        //    {
        //        return b + a + b;
        //    }
        //    else
        //    {
        //        return a + b + a;
        //    }
        //}

        //9
        //static void Main(string[] args)
        //{
        //    Console.Write("1-satirni kiriting : ");
        //    var a = Console.ReadLine();
        //    Console.Write("2-satirni kiriting : ");
        //    var b = Console.ReadLine();
        //    var res = NonStart(a, b);
        //    Console.WriteLine(res);
        //}
        //static string NonStart(string a, string b)
        //{
        //    var s1 = a.Substring(1, a.Length - 1);
        //    var s2 = b.Substring(1, b.Length - 1);
        //    return s1 + s2;
        //}

        //10
        //static void Main(string[] args)
        //{
        //    Console.Write("satirni kirit : ");
        //    var s = Console.ReadLine();
        //    var res = Left2(s);
        //    Console.WriteLine(res);
        //}
        //static string Left2(string str)
        //{
        //    var s1 = str.Substring(0, 2);
        //    var s2 = str.Substring(2);
        //    return s2 + s1;
        //}

        //11
        //static void Main(string[] args)
        //{
        //    Console.Write("Satirni yoz : ");
        //    var s = Console.ReadLine();
        //    Console.WriteLine(TheEnd(s,true));
        //    Console.WriteLine(TheEnd(s,false));
        //}
        //static string TheEnd(string str,bool front)
        //{
        //    if(front)
        //    {
        //        return str.Substring(0, 1);
        //    }
        //    else
        //    {
        //        return str.Substring(str.Length - 1);
        //    }
        //}

        //12
        //static void Main(string[] args)
        //{
        //    Console.Write(" satirni kirit : ");
        //    string s = Console.ReadLine();
        //    Console.Write(" sonni kirit : ");
        //    int num = int.Parse(Console.ReadLine());
        //    var res = NTwice(s, num);
        //    Console.WriteLine(res);
        //}
        //static string NTwice(string s, int num)
        //{
        //    string res = s.Substring(0, num);
        //    string res2 = s.Substring(s.Length - num);
        //    return res + res2;
        //}

        //13
        //static void Main(string[] args)
        //{
        //    Console.Write(" Toq uzunlikdagi satir kirit : ");
        //    var s= Console.ReadLine();
        //    Console.WriteLine(MiddleThree(s));
        //}
        //static string MiddleThree(string str)
        //{
        //    var middl = str.Substring(str.Length / 2 -1 ,3);
        //    return middl;
        //}

        //14
        //static void Main(string[] args)
        //{
        //    Console.Write("a sonini kirting : ");
        //    string a = Console.ReadLine();
        //    Console.Write("b sonini kirting : ");
        //    string b = Console.ReadLine();
        //    var res = ConCat(a, b);
        //    Console.WriteLine(res);
        //}
        //static string ConCat(string a, string b)
        //{
        //    var s1 = a.Substring(a.Length - 1);
        //    var s2 = b.Substring(0,1);
        //    if (s1 == s2)
        //    {
        //        return a + b.Substring(1);
        //    }
        //    else
        //    {
        //        return a+b;
        //    }
        //}

        //15
        //static void Main(string[] args)
        //{
        //    Console.Write(" Satirni kirit : ");
        //    var s = Console.ReadLine();
        //    Console.WriteLine(LastTwo(s));
        //}
        //static string LastTwo(string str)
        //{
        //    if (str.Length < 2)
        //    {
        //        return str;
        //    }
        //    var res1 = str.Substring(str.Length - 1);
        //    var res2 = str.Substring(str.Length - 2, 1);
        //    var res3 = str.Substring(0, str.Length - 2);
        //    return res3 + res1 + res2;
        //}

        //16
        static void Main(string[] args)
        {
            Console.Write("Satirni kirit : ");
            var s = Console.ReadLine();
            Console.WriteLine(SeeColor(s));
        }
        static string SeeColor(string str)
        {
            if(str.Length<4)
            {
                return "";
            }
            var res1 = str.Substring(0, 3);
            var res2 = str.Substring(0,4);
            if (res1 == "red")
            {
                return "red";
            }
            else if (res2 == "blue")
            {
                return "blue";
            }
            return "";
        }




    }
}

