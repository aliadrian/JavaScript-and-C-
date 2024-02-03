using System;

public class kata
{
    public static string boolean_to_string(bool b)
    {
        // my solution
        if (b)
        {
            b.ToString();
        }
        else
        {
            b.ToString();
        }

        return b.ToString();

        // better solution
        // public class kata {
        //   public static string boolean_to_string(bool b)
        //     => Convert.ToString(b);
        // }
    }
}

namespace Solution
{
    using NUnit.Framework;
    using System;


    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void MyTest()
        {
            Assert.AreEqual("True", kata.boolean_to_string(true));
            Assert.AreEqual("False", kata.boolean_to_string(false));
        }
    }
}