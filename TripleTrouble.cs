using System;
using System.Collections.Generic;
using NUnit.Framework;

public class Kata
{
  public static int TripleDouble(long num1, long num2)
  {
    string s1 = num1.ToString();
    string s2 = num2.ToString();
    int straightTriple = -1;

    for (int i = 0; i < s1.Length - 2; i++)
    {
      if (s1[i] == s1[i + 1] && s1[i] == s1[i + 2])
      {
        straightTriple = s1[i] - '0';
        break;
      }
    }

    if (straightTriple == -1)
        return 0;

    for (int i = 0; i < s2.Length - 1; i++)
    {
      if (s2[i] == s2[i + 1])
      {
        int straightDouble = s2[i] - '0';
        if (straightDouble == straightTriple)
          return 1;
      }
    }

    return 0;
  }
}

[TestFixture]
public class Tests
{
  [Test]
  [TestCase(451999277, 41177722899, ExpectedResult=1)]
  [TestCase(1222345, 12345, ExpectedResult=0)]
  [TestCase(12345, 12345, ExpectedResult=0)]
  [TestCase(666789, 12345667, ExpectedResult=1)]
  [TestCase(10560002, 100, ExpectedResult=1)]
  [TestCase(1112, 122, ExpectedResult=0)]
  public static int FixedTest(long s1, long s2)
  {
    return Kata.TripleDouble(s1, s2);
  }
}