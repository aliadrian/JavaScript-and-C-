using System;
using System.Collections.Generic;

public class Kata
{
    public static int Solve(string s)
    {
      string alphabet = "abcdefghijklmnopqrstuvwxyz";
			Dictionary<char, int> letterValues = new Dictionary<char, int>();

			for (int i = 0; i < 26; i++)
			{
				char c = alphabet[i];
				letterValues[c] = i + 1;
			}

			int maxSum = 0;
			int currentSum = 0;

			foreach (char c in s)
			{
				if ("aeiouAEIOU".Contains(c))
				{
					maxSum = Math.Max(maxSum, currentSum);
					currentSum = 0;
				}
				else
				{
					currentSum += letterValues[c];
				}
			}

			// Checks one last time in case the last substring is a consonant substring.
			maxSum = Math.Max(maxSum, currentSum);

			return maxSum;
    }
}

namespace Solution
{
  using NUnit.Framework;

  [TestFixture]
  public class Tests
  {
    [TestCase("zodiac", 26)]
    [TestCase("chruschtschov", 80)]
    [TestCase("khrushchev", 38)]
    [TestCase("strength", 57)]
    [TestCase("catchphrase", 73)]
    [TestCase("twelfthstreet", 103)]
    [TestCase("mischtschenkoana", 80)]
    public void BasicTests(string input, int expected)
    {
      Assert.That(Kata.Solve(input), Is.EqualTo(expected));
    }
  }
}