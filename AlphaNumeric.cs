using System;
using System.Text.RegularExpressions;
public class Kata
{
    public static bool Alphanumeric(string str)
    {
        // My solution
        var regexItem = new Regex("[^A-Za-z0-9]");

        if (!regexItem.IsMatch(str) && !String.IsNullOrEmpty(str))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // Shorter solution
    // return str.All(c => Char.IsLetterOrDigit(c)) && !string.IsNullOrEmpty(str);
}

namespace Solution
{
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;

    [TestFixture]
    public class Sample_Tests
    {
        private static IEnumerable<TestCaseData> testCases
        {
            get
            {
                yield return new TestCaseData("Mazinkaiser").Returns(true);
                yield return new TestCaseData("hello world_").Returns(false);
                yield return new TestCaseData("PassW0rd").Returns(true);
                yield return new TestCaseData("     ").Returns(false);
            }
        }

        [Test, TestCaseSource("testCases")]
        public bool Test(string str) => Kata.Alphanumeric(str);
    }
}