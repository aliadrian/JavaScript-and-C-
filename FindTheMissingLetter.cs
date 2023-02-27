using System;

public class Kata
{
    public static char FindMissingLetter(char[] array)
    {
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] - array[i - 1] != 1)
                return (char)((int)array[i] - 1);
        }

        throw new Exception("No return value");
    }
}

namespace Solution
{
    using NUnit.Framework;
    using System;
    using System.Linq;

    public class KataTests
    {
        [Test]
        public void ExampleTests()
        {
            Assert.AreEqual('e', Kata.FindMissingLetter(new[] { 'a', 'b', 'c', 'd', 'f' }));
            Assert.AreEqual('P', Kata.FindMissingLetter(new[] { 'O', 'Q', 'R', 'S' }));
        }
    }
}