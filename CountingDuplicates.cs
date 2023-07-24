
using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

public class Kata
{
  public static int occurance(char[] arr, int x)
  {
    int count = 0;
    foreach (int num in arr)
    {
      if (x == num)
      {
        count++;
      }
    }
    return count;
  }

  public static int DuplicateCount(string str)
  {
    Dictionary<char, int> charCounts = new Dictionary<char, int>();
    char[] chars = str.ToLower().ToCharArray();

    foreach (var i in chars.Distinct())
    {
      int count = occurance(chars, i);
      if (count >= 2)
      {
        charCounts.Add(i, count);
      }
      else
      {
        charCounts[i] = 0;
      }
    }
    int countOfRepeatedChars = charCounts.Count(kv => kv.Value >= 2);
    return countOfRepeatedChars;
  }
}

[TestFixture]
public class KataTest
{
  [Test]
  public void KataTests()
  {
    Assert.AreEqual(0, Kata.DuplicateCount(""));
    Assert.AreEqual(0, Kata.DuplicateCount("abcde"));
    Assert.AreEqual(2, Kata.DuplicateCount("aabbcde"));
    Assert.AreEqual(2, Kata.DuplicateCount("aabBcde"), "should ignore case");
    Assert.AreEqual(1, Kata.DuplicateCount("Indivisibility"));
    Assert.AreEqual(2, Kata.DuplicateCount("Indivisibilities"), "characters may not be adjacent");
  }
}