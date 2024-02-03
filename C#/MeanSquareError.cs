using System;

public class Kata
{
  public static double Solution(int[] firstArray, int[] secondArray)
  {
    double[] z = new double[firstArray.Length];
    double sum = 0;

    for (int i = 0; i < firstArray.Length; i++)
    {
      double a = firstArray[i];
      double b = secondArray[i];
      double v = Math.Abs(a - b);

      z[i] = v * v;
    }

    foreach (var index in z)
    {
      sum += index;
    }

    double result = sum / firstArray.Length;

    return result;
  }
}

// Shorter solution
//var dist = 0.00;

//for (var i = 0; i < firstArray.Length; i++)
//{
//	dist += Math.Pow(firstArray[i] - secondArray[i], 2);
//}

//return dist / firstArray.Length;

namespace Solution
{
  using NUnit.Framework;
  using System;

  [TestFixture]
  public class SolutionTest
  {
    [Test, Description("Sample Tests")]
    public void SampleTest()
    {
      Assert.AreEqual(9, Kata.Solution(new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }));
      Assert.AreEqual(16.5, Kata.Solution(new int[] { 10, 20, 10, 2 }, new int[] { 10, 25, 5, -2 }));
      Assert.AreEqual(1, Kata.Solution(new int[] { 0, -1 }, new int[] { -1, 0 }));
    }
  }
}