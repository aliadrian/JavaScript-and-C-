namespace Kata
{
  public static class Problem
  {
    public static string CamelCase(this string str)
    {
      string[] camelCase = str.TrimStart().Split(" ");
      string newString = string.Empty;

      foreach (string s in camelCase)
      {
        if (s.Length > 0)
        {
          newString += s.Substring(0, 1).ToUpper() + s.Substring(1, s.Length - 1);
        }
      }

      return newString;
    }
  }
}

namespace Solution
{
  using NUnit.Framework;
  using System;
  using Kata;

  [TestFixture]
  public class Test
  {
    [Test]
    public void BasicTests()
    {
      Assert.AreEqual("TestCase", "test case".CamelCase());
      Assert.AreEqual("CamelCaseMethod", "camel case method".CamelCase());
      Assert.AreEqual("SayHello", "say hello".CamelCase());
      Assert.AreEqual("CamelCaseWord", " camel case word".CamelCase());
      Assert.AreEqual("", "".CamelCase());
    }
  }
}