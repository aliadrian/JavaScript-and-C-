public class Kata
{

    public static string CreatePhoneNumber(int[] numbers)
    {
        var a = numbers[0];
        var b = numbers[1];
        var c = numbers[2];
        var d = numbers[3];
        var f = numbers[4];
        var g = numbers[5];
        var h = numbers[6];
        var i = numbers[7];
        var j = numbers[8];
        var k = numbers[9];

        string phoneNumber = $"({a}{b}{c}) {d}{f}{g}-{h}{i}{j}{k}";

        return phoneNumber;
    }
}

//better solution
// public class Kata
// {
//   public static string CreatePhoneNumber(int[] numbers)
//   {
//     return long.Parse(string.Concat(numbers)).ToString("(000) 000-0000");
//   }
// }

// using System.Linq;
// public class Kata
// {
//   public static string CreatePhoneNumber(int[] numbers)
//   {
//     return string.Format("({0}{1}{2}) {3}{4}{5}-{6}{7}{8}{9}",numbers.Select(x=>x.ToString()).ToArray());
//   }
// }

namespace Solution
{
    using NUnit.Framework;

    [TestFixture]
    public class Tests
    {
        [Test]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }, ExpectedResult = "(123) 456-7890")]
        [TestCase(new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, ExpectedResult = "(111) 111-1111")]
        public static string FixedTest(int[] numbers)
        {
            return Kata.CreatePhoneNumber(numbers);
        }
    }
}