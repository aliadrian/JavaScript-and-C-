// INSTRUCTIONS
// Given two integers a and b, which can be positive or negative, find the sum of all the integers between and including them and return it. If the two numbers are equal return a or b.

// Note: a and b are not ordered!

// Examples (a, b) --> output (explanation)
// (1, 0) --> 1 (1 + 0 = 1)
// (1, 2) --> 3 (1 + 2 = 3)
// (0, 1) --> 1 (0 + 1 = 1)
// (1, 1) --> 1 (1 since both are same)
// (-1, 0) --> -1 (-1 + 0 = -1)
// (-1, 2) --> 2 (-1 + 0 + 1 + 2 = 2)

using NUnit.Framework;
using System;
public class Sum
{
    public int GetSum(int a, int b)
    {
        int min = Math.Min(a, b);
        int max = Math.Max(a, b);

        return (max - min + 1) * (max + min) / 2;
    }
}

[TestFixture]
public class SumTest1
{
    Sum s = new Sum();

    [Test]
    public void Test1()
    {
        Assert.AreEqual(1, s.GetSum(0, 1));
        Assert.AreEqual(-1, s.GetSum(0, -1));
    }
}
