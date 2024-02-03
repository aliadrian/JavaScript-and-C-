using System;
using System.Text.RegularExpressions;
using NUnit.Framework;

namespace Solution
{
  public static class Kata
  {
    public static string RemoveParentheses(string s)
    {
      while (Regex.IsMatch(s, @"\([^()]*\)"))
      {
        s = Regex.Replace(s, @"\([^()]*\)", "");
      }
      return s;
    }
  }
}

namespace Solution
{
  [TestFixture]
  public class SolutionTest
  {
    [Test]
    public void BasicTests()
    {
      Assert.AreEqual("exampleexample", Kata.RemoveParentheses("example(unwanted thing)example"));
      Assert.AreEqual("example  example", Kata.RemoveParentheses("example (unwanted thing) example"));
      Assert.AreEqual("a e", Kata.RemoveParentheses("a (bc d)e"));
      Assert.AreEqual("a", Kata.RemoveParentheses("a(b(c))"));
      Assert.AreEqual("hello example  something", Kata.RemoveParentheses("hello example (words(more words) here) something"));
      Assert.AreEqual("  ", Kata.RemoveParentheses("(first group) (second group) (third group)"));
    }
  }
}
