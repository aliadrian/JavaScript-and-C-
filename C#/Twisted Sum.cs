// Find the sum of the digits of all the numbers from 1 to N (both ends included).

// Examples
// # N = 4
// 1 + 2 + 3 + 4 = 10

// # N = 10
// 1 + 2 + 3 + 4 + 5 + 6 + 7 + 8 + 9 + (1 + 0) = 46

// # N = 12
// 1 + 2 + 3 + 4 + 5 + 6 + 7 + 8 + 9 + (1 + 0) + (1 + 1) + (1 + 2) = 51

public class TwistedSum
{
  public static long Solution(long n)
  {
    List<int> listBelowTen = new List<int>();
    List<int> listAboveTen = new List<int>();

    int numberOne = 1;

    while (numberOne <= n)
    {
      listBelowTen.Add(numberOne++);
    }

    if (n >= 10)
    {
      listBelowTen.RemoveAll(i => i >= 10);
    }

    while (n >= 10)
    {
      listAboveTen.AddRange(n.ToString().Select(c => Convert.ToInt32(c.ToString())));
      n--;
    }

    return listBelowTen.Sum() + listAboveTen.Sum();
  }
}