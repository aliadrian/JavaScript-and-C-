using System;

public static class Kata
{
  public static string Encrypt(string text, int rule)
  {
    string characters = String.Empty;
    foreach (var c in text)
    {
      int x = Convert.ToInt32(c);
      int encrypted = (x + rule) % 256;

      if (encrypted < 0)
      {
        encrypted += 256;
      }

      characters += Char.ConvertFromUtf32(encrypted);
    }

    return characters;
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
    public void SampleTest()
    {
      Assert.That(Kata.Encrypt("", 1), Is.EqualTo(""));
      Assert.That(Kata.Encrypt("a", 1), Is.EqualTo("b"));
      Assert.That(Kata.Encrypt("please encrypt me", 2), Is.EqualTo("rngcug\"gpet{rv\"og"));
    }
  }
}