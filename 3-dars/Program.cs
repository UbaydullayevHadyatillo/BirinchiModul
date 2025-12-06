////homeworks1.3.1
////
//for (var i = 100; i < 1000; i++)
//{
//    sum = 0;
//    sum += i / 1 % 10;
//    sum += i / 10 % 10;
//    sum += i / 100 % 10;
//    if (sum > 20)
//    {
//        Console.Write($"{i}, ");
//    }
//}

////
//for (var i = 100; i < 1000; i++)
//{
//    if (i / 100 == i % 10  && i /10 %10 != i %10)
//    {
//        Console.Write($"{i}, ");
//    }
//}

////
//for (var i = 10; i < 100; i++)
//{
//    sum = 1;
//    sum *= i / 1 % 10;
//    sum *= i / 10 % 10;
//    if (sum > 12)
//    {
//        caunt++;
//        fullSum += sum;
//    }
//}
//Console.WriteLine($"Count(N) : {caunt}, FullSum(+) : {fullSum}");

////
//for (var i = 100; i < 1000; i++)
//{
//    sum = i / 10 % 10;
//    if (sum == 2 || sum == 5)
//    {
//        Console.Write($"{i}, ");
//    }
//}

////
//intVaule1 = 5;
//for (var i = 0; i < intVaule1; i++)
//{
//    Console.Write($"{intVaule1}, ");
//}

////
//intVaule1 = 3;
//intVaule2 = 7;
//for (var i = 0; i < intVaule2; i++)
//{
//    Console.Write($"{intVaule1}, ");
//}

////
//intVaule1 = 3;
//intVaule2 = 7;
//for (var i = 0; i < intVaule1; i++)
//{
//    Console.Write($"{intVaule2}, ");
//}

////
//intVaule1 = 9;
//for(var i=1; i <= intVaule1; i++)
//{
//    if (intVaule1 % i == 0)
//    {
//        Console.Write($"{i}, ");
//    }
//}

////
//intVaule1 = 9;
//caunt = 0;
//for (var i = 1; i <= intVaule1; i++)
//{

//    if (intVaule1 % i == 0)
//    {
//        caunt++;
//    }
//}
//Console.WriteLine($"{caunt}");

////
//intVaule1 = 9;
//fullSum = 0;
//for (var i = 1; i <= intVaule1; i++)
//{

//    if (intVaule1 % i == 0)
//    {
//       fullSum += i;
//    }
//}
//Console.WriteLine($"{fullSum}");

///
//intVaule1 = 11;
//caunt = 0;
//for (var i = 2; i <= intVaule1; i++)
//{
//    if (intVaule1 % i == 0)
//    {
//        caunt++;
//    }
//}
//if (caunt == 1)
//{
//    Console.WriteLine($"{intVaule1} soni tub son");
//}
//else
//{
//    Console.WriteLine($"{intVaule1} soni tub son emas");
//}

////
//intVaule1 = 11;
//intVaule2 = 7;
//caunt = 0;
//for (var i = 1; i <= intVaule1; i++)
//{
//    if (intVaule1 % i == 0)
//    {
//        caunt++;
//    }
//}
//for (var i = 1; i <= intVaule2; i++)
//{
//    if (intVaule1 % i == 0)
//    {
//        sum++;
//    }
//}
//if (caunt == 2 && sum == 2)
//{
//    Console.WriteLine($"{intVaule1 + intVaule2} soni tub son");
//}
//else
//{
//    Console.WriteLine($"{intVaule1 * intVaule2} soni tub son emas");
//}

////
//intVaule1 = 7000;
//for (var i = 3; i <= 60; i++)
//{
//    Console.WriteLine($"{i} → {i * intVaule1}");
//}

////
//intVaule1 = 50;
//caunt = 0;
//for (var i = 23; i <= intVaule1; i++)
//{
//    if (i % 3 != 0)
//    {
//        caunt++;
//        Console.Write($"{i}, ");
//    }
//}
//Console.WriteLine();
//Console.WriteLine($"soni: {caunt}");

////
//intVaule1 = 20;
//intVaule2 = 30;
//caunt = 0;
//sum = 0;
//for (var i = 1; i <= Math.Max(intVaule1,intVaule2); i++)
//{
//    if (intVaule1 % i == 0)
//    {
//        caunt++;
//    }
//    if (intVaule2 % i == 0)
//    {
//        sum++;
//    }
//}
//if (caunt > sum)
//{
//    Console.WriteLine($"{intVaule1} bo'luvchilari ko'p");
//}
//else
//{
//    Console.WriteLine($"{intVaule2} bo'luvchilari ko'p");
//}

//// M: 16
//intVaule1 = 5;
//intVaule2 = 10;
//fullSum = 0;
//for (var i = intVaule1+1; i < intVaule2; i++)
//{
// fullSum += i;
//}
//Console.WriteLine($"{fullSum}");


///homeworsk 1.3.2

////1 
//for(var i = 2; i < 10; i++)
//{
//    for (var j = 2; j < 10; j++)
//    {
//        Console.Write($"{j} * {i} = {i * j}\t");
//    }
//    Console.WriteLine();
//}

////2
//intVaule1 = 2;
//intVaule2 = 6;
//for (var i = intVaule1+1; i < intVaule2; i++)
//{
//    for (var j = 0; j <i; j++)
//    {
//        Console.Write($"{i} ");
//    }
//}

////3
//for (var i = 1; i <= 100; i++)
//{
//    caunt = 0;
//    for (var j = 1; j <= i; j++)
//    {
//        if (i % j == 0)
//        {
//            caunt++;
//        }
//    }
//    if(caunt == 2)
//    {
//        Console.Write($"{i}, ");
//    }
//}

////4
//intVaule1 = 2;
//intVaule2 = 30;
//for (var i = intVaule1; i <= intVaule2; i++)
//{
//    caunt = 0;
//    for (var j = 1; j <= i; j++)
//    {
//        if (i % j == 0)
//        {
//            caunt++;
//        }
//    }
//    if (caunt == 2)
//    {
//        Console.Write($"{i}, ");
//    }
//}

////5
//intVaule1 = 5;
//for (var i = 0; i < intVaule1; i++)
//{
//    for (var j = 0; j < intVaule1; j++)
//    {
//        Console.Write($"* ");
//    }
//    Console.WriteLine();
//}

////6
//intVaule1 = 5;
//for (var i = 0; i < intVaule1; i++)
//{
//    for (var j = 0; j < intVaule1; j++)
//    {
//        if (j == 0 || intVaule1 - 1 == j)
//        {
//            Console.Write($"* ");
//        }
//        else
//        {
//            Console.Write("  ");
//        }
//    }
//    Console.WriteLine();
//}

////7
//intVaule1 = 5;
//for (var i = 0; i < intVaule1; i++)
//{
//    for (var j = 0; j < intVaule1; j++)
//    {
//        if (i == 0 || intVaule1 - 1 == i)
//        {
//            Console.Write($"* ");
//        }
//        else
//        {
//            Console.Write("  ");
//        }
//    }
//    Console.WriteLine();
//}

////8
//intVaule1 = 5;
//for (var i = 0; i < intVaule1; i++)
//{
//    for (var j = 0; j < intVaule1; j++)
//    {
//        if (j == 0 || intVaule1 - 1 == j || i == 0 || intVaule1 - 1 == i)
//        {
//            Console.Write($"* ");
//        }
//        else
//        {
//            Console.Write("  ");
//        }
//    }
//    Console.WriteLine();
//}

////9
//intVaule1 = 5;
//for (var i = 0; i < intVaule1; i++)
//{
//    for (var j = 0; j < intVaule1; j++)
//    {
//        if (j == 0 || intVaule1 - 1 == j || intVaule1/2==i)
//        {
//            Console.Write($"* ");
//        }
//        else
//        {
//            Console.Write("  ");
//        }
//    }
//    Console.WriteLine();
//}

////10
//intVaule1 = 5;
//for (var i = 0; i < intVaule1; i++)
//{
//    for (var j = 0; j < intVaule1; j++)
//    {
//        if (j == 0 || intVaule1 - 1 == i || intVaule1 / 2 == i || i ==0)
//        {
//            Console.Write($"* ");
//        }
//        else
//        {
//            Console.Write("  ");
//        }
//    }
//    Console.WriteLine();
//}

////11
//intVaule1 = 5;
//for (var i = 0; i < intVaule1; i++)
//{
//    for (var j = 0; j < intVaule1; j++)
//    {
//        if (i == 0 || intVaule1 / 2 == j)
//        {
//            Console.Write($"* ");
//        }
//        else
//        {
//            Console.Write("  ");
//        }
//    }
//    Console.WriteLine();
//}

////12
//intVaule1 = 5;
//for (var i = 0; i < intVaule1; i++)
//{
//    for (var j = 0; j < intVaule1; j++)
//    {
//        if ( intVaule1 /2 == j || intVaule1 / 2 == i)
//        {
//            Console.Write($"* ");
//        }
//        else
//        {
//            Console.Write("  ");
//        }
//    }
//    Console.WriteLine();
//}

////13
//intVaule1 = 5;
//for (var i = 0; i < intVaule1; i++)
//{
//    for (var j = 0; j < intVaule1; j++)
//    {
//        if (intVaule1 / 2 == j || intVaule1 / 2 == i || j == 0 || intVaule1 - 1 == j || i == 0 || intVaule1 - 1 == i)
//        {
//            Console.Write($"* ");
//        }
//        else
//        {
//            Console.Write("  ");
//        }
//    }
//    Console.WriteLine();
//}

////14
//intVaule1 = 5;
//for (var i = 0; i < intVaule1; i++)
//{
//    for (var j = 0; j < intVaule1; j++)
//    {
//        if ( j == i)
//        {
//            Console.Write($"* ");
//        }
//        else
//        {
//            Console.Write("  ");
//        }
//    }
//    Console.WriteLine();
//}

////15
//intVaule1 = 5;
//for (var i = 0; i < intVaule1; i++)
//{
//    for (var j = 0; j < intVaule1; j++)
//    {
//        if (j + i == intVaule1-1)
//        {
//            Console.Write($"* ");
//        }
//        else
//        {
//            Console.Write("  ");
//        }
//    }
//    Console.WriteLine();
//}

////16
//intVaule1 = 5;
//for (var i = 0; i < intVaule1; i++)
//{
//    for (var j = 0; j < intVaule1; j++)
//    {
//        if (j == i || j == 0 || intVaule1-1==j )
//        {
//            Console.Write($"* ");
//        }
//        else
//        {
//            Console.Write("  ");
//        }
//    }
//    Console.WriteLine();
//}

////17
//intVaule1 = 5;
//for (var i = 0; i < intVaule1; i++)
//{
//    for (var j = 0; j < intVaule1; j++)
//    {
//        if (j == i || i == 0 || intVaule1 - 1 == i)
//        {
//            Console.Write($"* ");
//        }
//        else
//        {
//            Console.Write("  ");
//        }
//    }
//    Console.WriteLine();
//}

////18
//intVaule1 = 5;
//for (var i = 0; i < intVaule1; i++)
//{
//    for (var j = 0; j < intVaule1; j++)
//    {
//        if (j <= i )
//        {
//            Console.Write($"* ");
//        }
//        else
//        {
//            Console.Write("  ");
//        }
//    }
//    Console.WriteLine();
//}

////19
//intVaule1 = 5;
//for (var i = 0; i < intVaule1; i++)
//{
//    for (var j = 0; j < intVaule1; j++)
//    {
//        if (j >= i)
//        {
//            Console.Write($"* ");
//        }
//        else
//        {
//            Console.Write("  ");
//        }
//    }
//    Console.WriteLine();
//}

////20
//intVaule1 = 5;
//for (var i = 0; i < intVaule1; i++)
//{
//    for (var j = 0; j < intVaule1; j++)
//    {
//        if (j + i >= intVaule1-1)
//        {
//            Console.Write($"* ");
//        }
//        else
//        {
//            Console.Write("  ");
//        }
//    }
//    Console.WriteLine();
//}
//for (int i = 0; i < intVaule1; i++)
//{
//    for (int j = 0; j < intVaule1; j++)
//    {
//        if (j + i >= intVaule1 - 1)
//        {
//            Console.Write((i+1)+""+(j+1 ) +" ");
//        }
//        else
//        {
//            Console.Write("   ");
//        }
//    }
//    Console.WriteLine();
//}

////21
//intVaule1 = 5;
//for (var i = 0; i < intVaule1; i++)
//{
//    for (var j = 0; j < intVaule1; j++)
//    {
//        Console.Write($"{i+1} ");
//    }
//    Console.WriteLine();
//}

////22
//intVaule1 = 5;
//for (var i = 0; i < intVaule1; i++)
//{
//    for (var j = 0; j < intVaule1; j++)
//    {
//        if (j == i)
//        {
//            Console.Write($"{i+1} ");
//        }
//        else
//        {
//            Console.Write("  ");
//        }
//    }
//    Console.WriteLine();
//}

////23
//intVaule1 = 5;
//for (var i = 0; i < intVaule1; i++)
//{
//    for (var j = 0; j < intVaule1; j++)
//    {
//        if (i >= j)
//        {
//            Console.Write($"{i+1} ");
//        }
//        else
//        {
//            Console.Write("  ");
//        }
//    }
//    Console.WriteLine();
//}

////24
//intVaule1 = 5;
//for (var i = 0; i < intVaule1; i++)
//{
//    for (var j = 0; j < intVaule1; j++)
//    {
//        if (j == i || i + j == intVaule1 -1)
//        {
//            Console.Write($"$ ");
//        }
//        else
//        {
//            Console.Write("  ");
//        }
//    }
//    Console.WriteLine();
//}

////homeworks 1.3.3
