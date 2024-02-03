using System;
using System.Text;
using System.Text.RegularExpressions;
using NUnit.Framework;

public class Kata
{
  public static string DecipherThis(string s)
  {
    StringBuilder sb = new StringBuilder();
    string[] words = s.Split(' ');
    if (s.Length > 0)
    {
      foreach (string word in words)
      {
        string resultString = Regex.Match(word, @"\d+").Value;
        int i = Convert.ToInt32(resultString);
        string converted = Char.ConvertFromUtf32(i);

        string newString = word.Substring(resultString.Length);
        string result = converted + newString;

        if (result.Length > 1)
        {
          char[] charArray = result.ToCharArray();
          char temp = charArray[1];
          charArray[1] = charArray[result.Length - 1];
          charArray[result.Length - 1] = temp;
          result = new string(charArray);
        }

        sb.Append(result);
        sb.Append(' ');
      }
    }
    else
    {
      return "";
    }

    return sb.ToString().Trim();
  }
}

[TestFixture]
public class DecipherThisTests
{
  [TestCase("", "")]
  [TestCase("65", "A")]
  [TestCase("65b", "Ab")]
  [TestCase("65cb", "Abc")]
  [TestCase("65dcb", "Abcd")]
  [TestCase("82yade 115te 103o", "Ready set go")]
  [TestCase("72olle 103doo 100ya", "Hello good day")]
  [TestCase("65 119esi 111dl 111lw 108dvei 105n 97n 111ka", "A wise old owl lived in an oak")]
  [TestCase("84kanh 121uo 80roti 102ro 97ll 121ruo 104ple", "Thank you Piotr for all your help")]
  [TestCase("84eh 109ero 104e 115wa 116eh 108sse 104e 115eokp", "The more he saw the less he spoke")]
  [TestCase("84eh 108sse 104e 115eokp 116eh 109ero 104e 104dare", "The less he spoke the more he heard")]
  [TestCase("72eva 97 103o 97t 116sih 97dn 115ee 104wo 121uo 100o", "Have a go at this and see how you do")]
  [TestCase("87yh 99na 119e 110to 97ll 98e 108eki 116tah 119esi 111dl 98dri", "Why can we not all be like that wise old bird")]
  public void BasicTests(string input, string expected)
  {
    Assert.AreEqual(expected, Kata.DecipherThis(input));
  }
}
