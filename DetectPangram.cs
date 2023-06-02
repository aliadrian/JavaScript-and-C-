using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public static class Kata
{
  public static bool IsPangram(string str)
  {
    string alphabet = "abcdefghijklmnopqrstuvwxyz";
    Regex rgx = new Regex("[^a-zA-Z]");
    str = rgx.Replace(str, "");
    int counter = 0;

    List<char> list = new List<char>();

    foreach (char c in str.ToLower())
    {
      list.Add(c);
    }

    list = list.Distinct().ToList();

    foreach (char c in alphabet)
    {
      if (list.Contains(c))
      {
        counter++;
      }
    }

    if (counter == 26)
    {
      return true;
    }
    else
    {
      return false;
    }
  }
}

namespace Solution
{
  using NUnit.Framework;
  using System;

  [TestFixture]
  public class Tests
  {
    [Test]
    public void SampleTests()
    {
      Assert.AreEqual(true, Kata.IsPangram("The quick brown fox jumps over the lazy dog."));
    }
  }
}
