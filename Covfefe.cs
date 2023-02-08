// INSTRUCTIONS
// Covfefe
// Your are given a string. You must replace any occurence of the sequence coverage by covfefe, however, if you don't find the word coverage in the string, you must add covfefe at the end of the string with a leading space.

// For the languages where the string is not immutable (such as ruby), don't modify the given string, otherwise this will break the test cases.



public static class Solution
{
    public static string Covfefe(string tweet)
    {
        if (tweet.Contains("coverage"))
        {

            string[] words = tweet.Split(' ');
            string manyString = "";
            string covfefe = "covfefe";
            {
                for (int i = 0; i < words.Length; i++)
                {
                    manyString += words[i].Replace(words[i], covfefe) + " ";
                }
                return manyString.Trim();
            }
        }
        else
        {
            return tweet + " " + "covfefe";
        }
    }
}

namespace azarias
{
    using NUnit.Framework;
    using System;

    // TODO: Replace examples and use TDD development by writing your own tests

    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void BasicTest()
        {
            Assert.AreEqual("covfefe", Solution.Covfefe("coverage"));
            Assert.AreEqual("covfefe covfefe", Solution.Covfefe("coverage coverage"));
            Assert.AreEqual("nothing covfefe", Solution.Covfefe("nothing"));
            Assert.AreEqual("double space  covfefe", Solution.Covfefe("double space "));
            Assert.AreEqual("covfefe covfefe", Solution.Covfefe("covfefe"));
            Assert.AreEqual(" covfefe", Solution.Covfefe(""));
        }

    }
}