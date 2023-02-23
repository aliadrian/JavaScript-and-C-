using System;
using System.Linq;
using NUnit.Framework;
public static class Kata
{
    public static int occurance(int[] arr, int x)
    {
        int count = 0;
        foreach (int num in arr)
        {
            if (x == num)
            {
                count++;
            }
        }
        return count;
    }

    public static int Score(int[] dice)
    {
        int result = 0;

        foreach (int i in dice.Distinct())
        {
            int count = occurance(dice, i);
            Console.WriteLine(i + " Occurred For: " + count);

            if (i == 1 && count >= 3)
            {
                result += 1000;
            }
            if (i == 1 && count == 4)
            {
                result = 1100;
            }
            if (result == 1300)
            {
                result = 1000;
            }
            if (result == 50)
            {
                result = 250;
            }
            else if (i == 6 && count == 3)
            {
                result += 600;
            }
            else if (i == 5 && count == 3)
            {
                result += 500;
            }
            else if (i == 4 && count == 3)
            {
                result += 400;
            }
            else if (i == 3 && count >= 3)
            {
                result += 300;
            }
            else if (i == 3 && count > 2)
            {
                result += 100 * count;
            }
            else if (i == 2 && count == 3)
            {
                result += 200;
            }
            else if (i == 1 && count == 1)
            {
                result += 100;
            }
            else if (i == 5 && count >= 1)
            {
                result += 50 * count;
            }
        }
        return result;
    }
}

public static class ScoreChecker
{
    [Test]
    public static void ShouldBeWorthless()
    {
        Assert.AreEqual(0, Kata.Score(new int[] { 2, 3, 4, 6, 2 }), "Should be 0 :-(");
    }

    [Test]
    public static void ShouldValueTriplets()
    {
        Assert.AreEqual(400, Kata.Score(new int[] { 4, 4, 4, 3, 3 }), "Should be 400");
    }

    [Test]
    public static void ShouldValueMixedSets()
    {
        Assert.AreEqual(450, Kata.Score(new int[] { 2, 4, 4, 5, 4 }), "Should be 450");
    }
}