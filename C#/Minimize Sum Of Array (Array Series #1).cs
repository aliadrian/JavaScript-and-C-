// Task
// Given an array of integers , Find the minimum sum which is obtained from summing each Two integers product .

// Notes
// Array/list will contain positives only .
// Array/list will always have even size
// Input >> Output Examples
// minSum({5,4,2,3}) ==> return (22) 
// Explanation:
// The minimum sum obtained from summing each two integers product ,  5*2 + 3*4 = 22
// minSum({12,6,10,26,3,24}) ==> return (342)
// Explanation:
// The minimum sum obtained from summing each two integers product ,  26*3 + 24*6 + 12*10 = 342
// minSum({9,2,8,7,5,4,0,6}) ==> return (74)
// Explanation:
// The minimum sum obtained from summing each two integers product ,  9*0 + 8*2 +7*4 +6*5 = 74

using System.Collections.Generic;
using System.Linq;

class Kata
{
  public static int MinSum(int[] a)
  {
    List<int> list = new List<int>();
    List<int> newList = a.ToList();
    int sum = 0;

    for (int x =  newList.Count - 1; x > -1; x--)
    {
      if(newList.Count == 0)
      {
        sum = list.Sum();
        break;
      }
      int max = newList.Max();
      int min = newList.Min();
      list.Add(max * min);
      newList.Remove(min);
      newList.Remove(max);
    }

    return sum;
  }
}