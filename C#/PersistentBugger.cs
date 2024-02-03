using System;

public class Persist 
{
	public static int Persistence(long n) 
	{
		int counter = 0;
    while (n.ToString().Length > 1)
    {
      long r = 1;
      foreach (char c in n.ToString())
      {
        int x = c - '0';
        r *= x;
      }
      n = r;
      counter++;
    }
    return counter;
	}
}

using System;
using NUnit.Framework;

[TestFixture]
public class PersistTests {

[Test]
  public void Test1() {
    Console.WriteLine("****** Basic Tests");    
    Assert.AreEqual(3, Persist.Persistence(39));
    Assert.AreEqual(0, Persist.Persistence(4));
    Assert.AreEqual(2, Persist.Persistence(25));
    Assert.AreEqual(4, Persist.Persistence(999));
  }
}