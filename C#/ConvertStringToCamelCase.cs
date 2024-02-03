using System;
using NUnit.Framework;

public class Kata
{
    public static string ToCamelCase(string str)
    {
        string[] words = str.Split('-', '_');
        string camelCase = words[0];

        for (int i = 1; i < words.Length; i++)
        {
            camelCase += char.ToUpper(words[i][0]) + words[i].Substring(1).ToLower();
        }

        return camelCase;
    }
}



[TestFixture]
public class KataTest
{
    [Test]
    public void KataTests()
    {
        Assert.AreEqual("theStealthWarrior", Kata.ToCamelCase("the_stealth_warrior"), "Kata.ToCamelCase('the_stealth_warrior') did not return correct value");
        Assert.AreEqual("TheStealthWarrior", Kata.ToCamelCase("The-Stealth-Warrior"), "Kata.ToCamelCase('The-Stealth-Warrior') did not return correct value");
    }
}