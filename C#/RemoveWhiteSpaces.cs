using System;

namespace Solution
{
  public static class SpacesRemover
  {
    // My solution
    public static string NoSpace(string input)
    {
      string[] strings = input.Split(' ');
      string newString = String.Empty;

      foreach (string s in strings)
      {
        if (s.Length > 0)
        {
          newString += s;
        }
      }

      return newString;
    }
  }
}

// Better solution
// input.Replace(" ", "");

namespace Solution
{
  using NUnit.Framework;
  using System;

  [TestFixture]
  public class SolutionTest
  {
    [Test]
    public void ExampleTests()
    {
      Assert.AreEqual("8j8mBliB8gimjB8B8jlB", SpacesRemover.NoSpace("8 j 8   mBliB8g  imjB8B8  jl  B"));
      Assert.AreEqual("88Bifk8hB8BB8BBBB888chl8BhBfd", SpacesRemover.NoSpace("8 8 Bi fk8h B 8 BB8B B B  B888 c hl8 BhB fd"));
      Assert.AreEqual("8aaaaaddddr", SpacesRemover.NoSpace("8aaaaa dddd r     "));
    }
  }
}