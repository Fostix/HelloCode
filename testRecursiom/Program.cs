﻿string NumbersFor(int a, int b)
{
    string result = string.Empty;
    for (int i = a; i <= b; i++)
    {
        result += $"{i} ";
    }
    return result;
}


string NumbersRec(int a, int b)
{
    if (a <= b) return $"{a} " + NumbersRec(a + 1, b);
    else return String.Empty;
}

Console.WriteLine(NumbersFor(1, 10));
Console.WriteLine(NumbersRec(1, 10));

string NumbersFor1(int a, int b)
{
    string result = String.Empty;
    for (int i = a; i <= b; i--)
    {
        result += $"{i} ";
    }
    return result;
}


string NumbersRec1(int a, int b)
{
    if (a <= b) return NumbersRec1(a + 1, b) + $"{a} ";
    else return String.Empty;
}

Console.WriteLine(NumbersFor1(1, 10));
Console.WriteLine(NumbersRec1(1, 10));



int SumFor(int n)
{
    int result = 0;
    for (int i = 1; i <= n; i++) result += i;
    return result;
}

int SumRec(int n)
{
    if (n == 0) return 0;
    else return n + SumRec(n - 1);
}

Console.WriteLine(SumFor(10));
Console.WriteLine(SumRec(10));


