using System;
using System.Linq;

public static class Kata
{
  public static int CountSmileys(string[] smileys)
  {
    int count = 0;

    foreach (string smiley in smileys)
    {
      if (!smiley.Any(Char.IsWhiteSpace))
      {
        if (smiley.Contains(";") && smiley.Contains(")") || smiley.Contains(":") && smiley.Contains(")") || smiley.Contains(":") && smiley.Contains("D") || smiley.Contains(";") && smiley.Contains("D"))
        {
          count++;
        }
        else
        {
          continue;
        }
      }
    }

    return count;
  }
}

namespace Solution
{
  using NUnit.Framework;
  using System;

  [TestFixture]
  public class SolutionTest
  {
    [Test]
    public void BasicTest()
    {
      Assert.AreEqual(4, Kata.CountSmileys(new string[] { ":D", ":~)", ";~D", ":)" }));
      Assert.AreEqual(2, Kata.CountSmileys(new string[] { ":)", ":(", ":D", ":O", ":;" }));
      Assert.AreEqual(1, Kata.CountSmileys(new string[] { ";]", ":[", ";*", ":$", ";-D" }));
      Assert.AreEqual(0, Kata.CountSmileys(new string[] { ";", ")", ";*", ":$", "8-D" }));
    }
  }
}