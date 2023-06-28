using System.Collections.Generic;

namespace myjinxin
{
  using System;
  
  public class Kata
  {
    public int SquareDigitsSequence(int a0){
        
    HashSet<int> set = new HashSet<int>();
    int count = 1;

    while (!set.Contains(a0))
    {
      set.Add(a0);
      int sum = 0;
      while (a0 > 0)
      {
        int digit = a0 % 10;
        sum += digit * digit;
        a0 /= 10;
      }
      a0 = sum;
      count++;
    }

    return count;
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
    public void BasicTests(){
      var kata=new Kata();
      
      Assert.AreEqual(9,  kata.SquareDigitsSequence(16));
      
      Assert.AreEqual(4,  kata.SquareDigitsSequence(103));
      
      Assert.AreEqual(2,  kata.SquareDigitsSequence(1));           
    }        
  }
}