using System;

public class Kata
{
  public static string NumberFormat(int number)
  {
    var numberFormat = function (number) 
    {
      return number.toString().replace(/\B(?=(\d{3})+(?!\d))/g, ",");
    };
  }
}

using NUnit.Framework;

[TestFixture]
public class Tests
{
  [Test]
  [TestCase(100000, ExpectedResult="100,000")]
  [TestCase(5678545, ExpectedResult="5,678,545")]
  public static string FixedTest(int num)
  {
    return Kata.NumberFormat(num);
  }
}