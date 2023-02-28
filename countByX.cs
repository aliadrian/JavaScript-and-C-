using System;
using NUnit.Framework;

public static class Kata
{
  public static int[] CountBy(int x, int n)
  {
    int[] z = new int[n];

    for (int i = 0; i < n; i++)
    {
      if (i <= 0)
      {
        z[i] = x;
      }
      else
      {
        z[i] = x * (i + 1);
      }
    }

    return z;
  }
}

[TestFixture]
public static class Test
{
  [Test]
  public static void CountBy1()
  {
    Assert.AreEqual(new int[] { 1, 2, 3, 4, 5 }, Kata.CountBy(1, 5), "Array does not match");
  }

  [Test]
  public static void CountBy2()
  {
    Assert.AreEqual(new int[] { 2, 4, 6, 8, 10 }, Kata.CountBy(2, 5), "Array does not match");
  }
}