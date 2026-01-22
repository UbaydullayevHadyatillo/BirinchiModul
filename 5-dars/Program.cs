namespace _5_dars;

internal class Program
{
    static void Main(string[] args)
    {
        //Console.Write("List uzunligini kirit : ");
        //var nums = int.Parse(Console.ReadLine());
        //List<int> list = new List<int>();
        //for (var i = 0; i < nums; i++)
        //{
        //    Console.Write("List elementi : ");
        //    var s = int.Parse(Console.ReadLine());
        //    list.Add(s);
        //}

        //1
        //var count = 0;
        //foreach(var res in list)
        //{
        //    if(99< res && res <1000)
        //    {
        //        count++;
        //    }
        //}
        //Console.WriteLine(count);

        //2
        //var count = 0;
        //foreach(var res in list)
        //{
        //    if(res % 2 == 0)
        //    {
        //        count++;
        //    }
        //}
        //Console.Write(count);

        //3
        //var count = 0;
        //foreach (var s in list)
        //{
        //    if (s % 2 != 0)
        //    {
        //        count++;
        //    }
        //}
        //Console.WriteLine(count);

        //4
        //var count = 0;
        //foreach (var s in list)
        //{
        //    if (s % 3 == 0 && s % 7 == 0)
        //    {
        //        count++;
        //    }
        //}
        //Console.WriteLine(count);

        //5
        //var count = 0;
        //var sum = 0;
        //foreach (var s in list)
        //{
        //    if (9 < s && s < 100 && s % 2 != 0)
        //    {
        //        count++;
        //        sum += s;
        //    }
        //}
        //Console.WriteLine(count);
        //Console.WriteLine(sum);

        //6
        //var temp = list[0];
        //list[0] = list[list.Count - 1];
        //list[list.Count - 1] = temp;
        //foreach(var res in list)
        //{
        //    Console.WriteLine(res);
        //}

        //7
        //var res = list[0] + list[1]+list[2];
        //Console.WriteLine(res);

        //8
        //var res = list[list.Count-3] + list[list.Count-2] + list[list.Count - 1];
        //Console.WriteLine(res);

        //9
        //var toq = 0;
        //var juft = 0;
        //foreach (var s in list)
        //{
        //    if (s % 2 == 0)
        //    {
        //        juft++;
        //    }
        //    else
        //    {
        //        toq++;
        //    }
        //}
        //if (toq > juft)
        //{
        //    Console.Write(true);
        //}
        //else
        //{
        //    Console.Write(false);
        //}

        //10
        //var sum = 0;
        //for(var i = 0; i< list.Count-1;i++)
        //{
        //    if(i%2==0)
        //    {
        //        list[i] = list[i] * 3;
        //    }
        //}
        //foreach(var res in list)
        //{
        //    Console.WriteLine(res);
        //}

        //11
        //foreach(var s in list)
        //{
        //    if (s % 5 == 0)
        //    {
        //        Console.WriteLine(true);
        //        break;
        //    }
        //    else
        //    {
        //        Console.WriteLine(false);
        //        break;
        //    }
        //}

        //12
        //if (9 < list[0] && list[0] < 100 && 9 < list[1] && list[1] < 100 && 9 < list[2] && list[2] < 100)
        //{
        //    Console.WriteLine(true);
        //}
        //else
        //{
        //    Console.WriteLine(false);
        //}

        //13
        //if (list[0] % 2 == 0 && list[1] % 2 == 0 && list[list.Count - 1] % 2 != 0 && list[list.Count - 2] % 2 != 0)
        //{
        //    Console.WriteLine(true);
        //}
        //else
        //{
        //    Console.WriteLine(false);
        //}

        //14
        //var min = list.Min();
        //Console.WriteLine(min);

        //21
        //var res = true;
        //for(var i = 0;i<list.Count-1;i++)
        //{
        //    if (list[i] >= list[i+1])
        //    {
        //        res = false;
        //        break;
        //    }
        //}
        //Console.WriteLine(res);

        //22
        //var res = true;
        //for(var i =0; i <list.Count-1;i++)
        //{
        //    if (list[i] <= list[i+1])
        //    {
        //        res = false;
        //    }
        //}
        //Console.WriteLine(res);

        //23
        //var minIndex = 0;
        //var maxIndex = 0;
        //for(var i =1;i < list.Count;i++)
        //{
        //    if (list[i] < list[minIndex])
        //    {
        //        minIndex = i;
        //    }
        //    if(list[i] > list[maxIndex])
        //    {
        //        maxIndex = i;
        //    }
        //}
        //var temp = list[minIndex];
        //list[minIndex]= list[maxIndex];
        //list[maxIndex]= temp;
        //foreach(var s in list)
        //{
        //    Console.WriteLine(s);
        //}

        //24
        //var sum = 0;
        //foreach (var s in list)
        //{
        //    sum += s;
        //}
        //Console.WriteLine(sum);

        //25
        //var sumMax = list[0] + list[1];
        //var index = 0;
        //for(var i = 1;i < list.Count-1;i++)
        //{
        //    var sum = list[i] + list[i + 1];
        //    if(sum>sumMax)
        //    {
        //        sum = sumMax;
        //        index = i;
        //    }
        //}
        //Console.WriteLine($"{list[index]} va {list[index+1]}");

        //27
        //List<int> a = new List<int> { 2, 5, 8};
        //List<int> b = new List<int> { 1, 4, 7};
        //List<int> c = new List<int>();
        //for (var i = 0; i < a.Count; i++)
        //{
        //    c.Add(a[i] * b[i]);
        //}
        //foreach(var s in c)
        //{
        //    Console.WriteLine(s);
        //}



    }
}
