using System;

namespace Solution
{
    class Solution
    {
        public static int[,] MultiplicationTable(int size)
        {
            int[,] result = new int[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    result[i, j] = (i + 1) * (j + 1);
                }
            }
            return result;
        }
    }
}

namespace Solution
{
    using NUnit.Framework;
    using System;

    // TODO: Replace examples and use TDD by writing your own tests

    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void MyTest()
        {
            int[,] expected = new int[,] { { 1, 2, 3 }, { 2, 4, 6 }, { 3, 6, 9 } };
            Assert.AreEqual(expected, Solution.MultiplicationTable(3));
        }
    }
}
