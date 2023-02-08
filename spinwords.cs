// my solution that didn't work
using System.Collections.Generic;
using System.Linq;
using System;

public class Kata
{
    //   public static string SpinWords(string sentence)
    //   {
    //     	string[] words = sentence.Split(' ');
    // 			string newString = "";
    // 			string notReversed = "";

    // 			foreach (string word in words)
    // 			{
    // 				if (word.Length >= 5)
    // 				{
    // 					newString += new string(word.ToCharArray().Reverse().ToArray()) + ' ';
    // 				}
    // 				else
    // 				{
    // 					notReversed += word + ' ';
    // 				}
    // 			}
    // 			return (notReversed + newString).Trim();
    //   }


    // solution

    public static string SpinWords(string sentence)
    {
        List<string> newWords = new List<string>();
        foreach (string word in sentence.Split(" "))
        {
            if (word.Length >= 5)
            {
                newWords.Add(new string(word.Reverse().ToArray()));
            }
            else
            {
                newWords.Add(word);
            }
        }
        return string.Join(" ", newWords);
    }
}

// using NUnit.Framework;
// using System;

[TestFixture]
public class Tests
{
    [Test]
    public static void Test1()
    {
        Assert.AreEqual("emocleW", Kata.SpinWords("Welcome"));
    }

    [Test]
    public static void Test2()
    {
        Assert.AreEqual("Hey wollef sroirraw", Kata.SpinWords("Hey fellow warriors"));
    }

    [Test]
    public static void Test3()
    {
        Assert.AreEqual("This is a test", Kata.SpinWords("This is a test"));
    }

    [Test]
    public static void Test4()
    {
        Assert.AreEqual("This is rehtona test", Kata.SpinWords("This is another test"));
    }

    [Test]
    public static void Test5()
    {
        Assert.AreEqual("You are tsomla to the last test", Kata.SpinWords("You are almost to the last test"));
    }

    [Test]
    public static void Test6()
    {
        Assert.AreEqual("Just gniddik ereht is llits one more", Kata.SpinWords("Just kidding there is still one more"));
    }
}