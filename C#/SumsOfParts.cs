using System;
using System.Collections.Generic;

class SumParts
{

    // My way of writing it 
  // public static int[] PartsSums(int[] ls)
  // {
  //   List<int> list = new List<int>();

  //   for (int i = 0; i < ls.Length + 1; i++)
  //   {
  //     int sum = 0;
  //     for (int j = i; j < ls.Length; j++)
  //     {
  //       sum += ls[j];
  //     }
  //     list.Add(sum);
  //   }

  //   return list.ToArray();
  // }

  // Updated version of the code optimized
  public static int[] PartsSums(int[] ls)
  {
    int n = ls.Length;
    int[] result = new int[n + 1];
    int sum = 0;

    for (int i = n - 1; i >= 0; i--)
    {
      sum += ls[i];
      result[i] = sum;
    }

    return result;
  }
}

[TestFixture]
public static class SumPartsTests 
{
  private static void dotest(int[] ls, int[] exp) { 
    int[] ans = SumParts.PartsSums(ls);
    Assert.AreEqual(exp, ans);
}

[Test]
  public static void atest0() 
  {        
    Console.WriteLine("Basic Tests");
    dotest(new int[] {}, new int[] {0});
    dotest(new int[] {0, 1, 3, 6, 10}, new int[] {20, 20, 19, 16, 10, 0});
    dotest(new int[] {1, 2, 3, 4, 5, 6}, new int[] {21, 20, 18, 15, 11, 6, 0});        
    dotest(new int[] {744125, 935, 407, 454, 430, 90, 144, 6710213, 889, 810, 2579358}, 
          new int[] {10037855, 9293730, 9292795, 9292388, 9291934, 9291504, 9291414, 9291270, 2581057, 2580168, 2579358, 0});
        
  }
}
