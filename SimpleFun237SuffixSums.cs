// For a = [1, 2, 3], the output should be [6, 5, 3].

// b[0]= 1 + 2 + 3 = 6
// b[1]=     2 + 3 = 5
// b[2]=         3 = 3
// For a = [1, 2, 3, -6], the output should be [0, -1, -3, -6].

// b[0]= 1 + 2 + 3 - 6 = 0
// b[1]=     2 + 3 - 6 = -1
// b[2]=         3 - 6 = -3
// b[3]=           - 6 = -6

namespace SuffixSums
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(SuffixSums(new int[] { 1, 123, 23 }));
    }

    public static int[] SuffixSums(int[] nums)
    {
      int[] sumAll = new int[nums.Length];

      int total = 0;
      int x = 0;
      for (int i = 0; i < nums.Length + 1; i++)
      {
        sumAll[x] = total;
        total = 0;
        if (i > 0)
          x++;
        for (int j = 0 + i; j < nums.Length; j++)
          total += nums[j];
      }

      return sumAll;
    }
  }
}
