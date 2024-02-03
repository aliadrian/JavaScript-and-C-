namespace myjinxin
{
  using System;
  using System.Collections.Generic;
  using System.Linq;

  public class Kata
  {
    public int[] CutTheRopes(int[] a){
      List<int> list = new List<int>();

      while (a.Length > 0)
      {
        list.Add(a.Length);
        int smallestNumber = a.Min();
        List<int> newList = new List<int>();

        foreach (int length in a)
        {
          int remainingLength = length - smallestNumber;
          if (remainingLength > 0)
          {
            newList.Add(remainingLength);
          }
        }

        a = newList.ToArray();
      }

      return list.ToArray();
    }
  }
}

namespace myjinxin
{
  using NUnit.Framework;
  using System;
    
  [TestFixture]
  public class myjinxin
  {      
    [Test]
    public void BasicTests()
    {
      var kata=new Kata();
      Assert.AreEqual(new int[]{5, 4, 2, 1},kata.CutTheRopes(new int[]{3, 3, 2, 9, 7}));
      Assert.AreEqual(new int[]{8, 6, 4, 1},kata.CutTheRopes(new int[]{1, 2, 3, 4, 3, 3, 2, 1}));
      Assert.AreEqual(new int[]{10, 9, 6, 5, 3, 1},kata.CutTheRopes(new int[]{13035, 6618, 13056, 20912, 1119, 13035, 6618, 6618, 8482, 13056}));
    }            
  }
}
