using System;
using System.Collections.Generic;
using System.Linq;

namespace Kata
{
  public static class Kata
  {
    public static int[] UpArray(int[] num)
		{
			List<int> list = num.ToList();
			int z = list.LastOrDefault();
      
      if (num.Length == 0 || list.Min() < 0 || list.Max() > 9)
      {
        return null;
      }
			else
			{
				if (z == 9)
				{
					for (int j = 0; j < list.Count; j++)
					{
						if (list[j] == 9)
						{
							list[j] = 0;
						}
						else
						{
							int k = num[list.Count - 2];
							k++;
							num[list.Count - 2] = k;
							num[list.Count - 1] = 0;

							return num;
						}
					}
				}
				else
				{
					z++;
					num[list.Count - 1] = z;
					return num;
				}
				List<int> newList = list;
				newList.Insert(0, 1);
				return newList.ToArray();
			}
		}
  }
}

namespace Kata 
{  
  [TestFixture]
  public class ArrayTest
  {
    [Test]
    public void Test1()
    {
      var num = new int[] {2, 3, 9};
      var newNum = new int[] {2, 4, 0};
      Assert.AreEqual(newNum, Kata.UpArray(num));
    }
    
    [Test]
    public void Test2()
    {
      var num = new int[] {4, 3, 2, 5};
      var newNum = new int[] {4, 3, 2, 6};
      Assert.AreEqual(newNum, Kata.UpArray(num));
    }
    
    [Test]
    public void Test3()
    {
      var num = new int[] {0, 4, 2};
      var newNum = new int[] {0, 4, 3};
      Assert.AreEqual(newNum, Kata.UpArray(num));
    }    
    
    [Test]
    public void Test4()
    {
      var num = new int[] {9, 9};
      var newNum = new int[] {1, 0, 0};
      Assert.AreEqual(newNum, Kata.UpArray(num));
    }
    
    [Test]
    public void UpBigArray()
    {
      var num = new int[] {9,2,2,3,3,7,2,0,3,6,8,5,4,7,7,5,8,0,7,5,3,2,6,7,8,4,2,4,2,6,7,8,7,4,5,2,1};
      var newNum = new int[] {9,2,2,3,3,7,2,0,3,6,8,5,4,7,7,5,8,0,7,5,3,2,6,7,8,4,2,4,2,6,7,8,7,4,5,2,2};
      Assert.AreEqual(newNum, Kata.UpArray(num));
    }     
  }
}