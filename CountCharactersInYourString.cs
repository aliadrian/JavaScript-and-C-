
using System;
using System.Collections.Generic;
using System.Linq;

// My solution
public class Kata
{
  public static int occurance(char[] arr, int x)
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

  public static Dictionary<char, int> Count(string str)
  {
    Dictionary<char, int> charCounts = new Dictionary<char, int>();
    char[] chars = str.ToCharArray();

    foreach (var i in chars.Distinct())
    {
      int count = occurance(chars, i);
      Console.WriteLine(i + " Occurred For: " + count);
      charCounts.Add(i, count);
    }

    return charCounts;
  }
}

// Better solution with LINQ
// public static Dictionary<char, int> Count(string str)
//   {
//     return str.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());
//   }

// Better solution without LINQ
//  public static Dictionary<char, int> Count(string str)
//   {
//       Dictionary<char, int> dictionary = new  Dictionary<char, int>();

//     foreach(char c in str)
//     {
//        if(dictionary.ContainsKey(c))
//        {
//           dictionary[c] += 1;
//        }
//        else
//        {
//          dictionary.Add(c,1);
//        }
//     }

//     return dic;
//   }