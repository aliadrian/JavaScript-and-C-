public static class Kata
{
    public static string AlphabetPosition(string text)
    {

        string result = "";
        text = text.ToUpper();
        for (int i = 0; i < text.Length; i++)
        {
            int code = text[i];
            if (code > 64 && code < 91) result += (code - 64) + " ";
        }
        return result.TrimEnd();
    }
}

// better solution

// using System.Linq;

// public static class Kata
// {
//   public static string AlphabetPosition(string text)
//   {
//     return string.Join(" ", text.ToLower()
//                                           .Where(c => char.IsLetter(c))
//                                           .Select(c => "abcdefghijklmnopqrstuvwxyz".IndexOf(c) + 1)
//                                           .ToArray());
//   }
// }

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
            Assert.AreEqual("20 8 5 19 21 14 19 5 20 19 5 20 19 1 20 20 23 5 12 22 5 15 3 12 15 3 11", Kata.AlphabetPosition("The sunset sets at twelve o' clock."));
            Assert.AreEqual("20 8 5 14 1 18 23 8 1 12 2 1 3 15 14 19 1 20 13 9 4 14 9 7 8 20", Kata.AlphabetPosition("The narwhal bacons at midnight."));
        }
    }
}