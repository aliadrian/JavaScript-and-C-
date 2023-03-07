using System;
using System.Numerics;
using NUnit.Framework;
public static class Kata
{
  public static string sumStrings(string a, string b)
  {
    // My solution that didn't work
    //BigInteger i = BigInteger.Parse(a) + BigInteger.Parse(b);

    //return i.ToString();

    // Correct solution
    BigInteger aInt;
    BigInteger bInt;

    BigInteger.TryParse(a, out aInt);
    BigInteger.TryParse(b, out bInt);

    return (aInt + bInt).ToString();
  }
}

[TestFixture]
public class CodeWarsTest
{
  [Test]
  public void Given123And456Returns579()
  {
    Assert.AreEqual("579", Kata.sumStrings("123", "456"));
  }
}