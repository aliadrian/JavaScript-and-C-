using System;
using NUnit.Framework;

namespace SimplePigLatin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SimplePigLatin("Pig latin is cool"));
        }

        public static string SimplePigLatin(string str)
        {
            string[] words = str.Split(' ');
            string newString = "";

            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);

            foreach (string word in words)
            {
                string firstLetter = word.Substring(0, 1);
                string restOfWord = word.Substring(1);

                if (word.Length > 1)
                {
                    newString += restOfWord + firstLetter + "ay" + " ";
                }
                else
                {
                    newString += restOfWord + firstLetter;
                }
            }

            return newString.Trim();
        }
    }
}


[TestFixture]
public class KataTest
{
    [Test]
    public void KataTests()
    {
        Assert.AreEqual("igPay atinlay siay oolcay", Kata.PigIt("Pig latin is cool"));
        Assert.AreEqual("hisTay siay ymay tringsay", Kata.PigIt("This is my string"));
    }
}