using System;
using NUnit.Framework;
using System.Linq;

public static class Kata
{
  public static int CountSheeps(bool[] sheeps)
  {
    int count = 0;
    foreach (var b in sheeps.Where(n => n != null))
    {
      if (b == true)
      {
        count++;
      }
    }
    return count;
  }

  // Similar solution
  public static int CountSheeps(bool[] sheeps)
  {
    return sheeps.Count(s => s);
  }
}


[TestFixture]
public class CountSheepsTests
{
  [Test]
  public void SampleTest()
  {
    var sheeps = new bool[] { true, false, true };

    Assert.AreEqual(2, Kata.CountSheeps(sheeps));
  }
}