using System;
public class Scramblies 
{   
  public static bool Scramble(string str1, string str2) 
  {
    string word = string.Empty;
    for (int i = 0; i < str2.Length; i++)
    {
      if (str1.Contains(str2[i]))
      {
        word += str2[i];
        str1 = str1.Remove(str1.IndexOf(str2[i]), 1);
      }
    }

    if (word == str2)
      return true;
    else
      return false;
  }
}

using System;
using NUnit.Framework;

[TestFixture]
public static class ScrambliesTests 
{

  private static void testing(bool actual, bool expected) 
  {
    Assert.AreEqual(expected, actual);
  }

[Test]
  public static void test1() 
  {
    testing(Scramblies.Scramble("rkqodlw","world"), true);
    testing(Scramblies.Scramble("cedewaraaossoqqyt","codewars"),true);
    testing(Scramblies.Scramble("katas","steak"),false);
    testing(Scramblies.Scramble("scriptjavx","javascript"),false);
    testing(Scramblies.Scramble("scriptingjava","javascript"),true);
    testing(Scramblies.Scramble("scriptsjava","javascripts"),true);
    testing(Scramblies.Scramble("javscripts","javascript"),false);
    testing(Scramblies.Scramble("aabbcamaomsccdd","commas"),true);
    testing(Scramblies.Scramble("commas","commas"),true);
    testing(Scramblies.Scramble("sammoc","commas"),true);
  }
}