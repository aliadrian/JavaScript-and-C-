using System.Collections.Generic;

public class SplitString
{
  public static string[] Solution(string str)
  {
      List<string> list = new List<string>();

			if (str.Length % 2 == 0)
			{
				for (int i = 0; i < str.Length; i++)
				{
					string[] arr = new string[] { str[i].ToString() + str[i + 1].ToString() };
					list.AddRange(arr);
					i++;
				}
			}
			else
			{
				for (int i = 0; i < str.Length; i++)
				{
					if (i == str.Length - 1)
					{
						list.Add(str[i].ToString() + '_');
					}
					else
					{
						string[] arr = new string[] { str[i].ToString() + str[i + 1].ToString() };
						list.AddRange(arr);
					}
					i++;
				}
			}

			return list.ToArray();
  }
}

namespace Solution 
{
  using NUnit.Framework;
  using System;  

  [TestFixture]
  public class SplitStringTests
  {
    [Test]
    public void BasicTests()
    {
      Assert.AreEqual(new string[] { "ab", "c_" }, SplitString.Solution("abc"));
      Assert.AreEqual(new string[] { "ab", "cd", "ef" }, SplitString.Solution("abcdef"));
    }
  }
}