using System;
using System.Linq;
using System.Text;
using NUnit.Framework;


// My solution
static class Diamond
{
    public static string Repeat(this string str, int n)
    {
        var result = string.Empty;

        for (var i = 0; i < n; i++)
            result += str;

        return result;
    }

    public static string print(int n)
    {
        if (n < 0 || (n % 2 == 0))
        {
            return null;
        }

        int halfHeight = (n - 1) / 2;
        string diamond = "*".Repeat(n) + "\n";

        for (int i = 1; i <= halfHeight; i++)
        {
            int stars = n - i * 2;
            int extremeSpaces = i;

            string line = Repeat(" ", extremeSpaces) + Repeat("*", stars) + "\n";
            diamond = line + diamond + line;
        }

        return diamond;
    }
}

// Better solution
public class Diamond
{
    public static string print(int n)
    {
        if (n % 2 == 0 || n < 0)
        {
            return null;
        }

        int middle = n / 2;
        StringBuilder sb = new StringBuilder();
        for (int index = 0; index < n; index++)
        {
            sb.Append(' ', Math.Abs(middle - index));
            sb.Append('*', n - Math.Abs(middle - index) * 2);
            sb.Append("\n");
        }

        return sb.ToString();
    }
}

[TestFixture]
public class DiamondTest
{

    [Test]
    public void TestNull()
    {
        Assert.IsNull(Diamond.print(0));
        Assert.IsNull(Diamond.print(-2));
        Assert.IsNull(Diamond.print(2));
    }

    [Test]
    public void TestDiamond1()
    {
        var expected = new StringBuilder();
        expected.Append("*\n");
        Assert.AreEqual(expected.ToString(), Diamond.print(1));
    }
    [Test]
    public void TestDiamond3()
    {
        var expected = new StringBuilder();
        expected.Append(" *\n");
        expected.Append("***\n");
        expected.Append(" *\n");

        Assert.AreEqual(expected.ToString(), Diamond.print(3));
    }

    [Test]
    public void TestDiamond5()
    {
        var expected = new StringBuilder();
        expected.Append("  *\n");
        expected.Append(" ***\n");
        expected.Append("*****\n");
        expected.Append(" ***\n");
        expected.Append("  *\n");

        Assert.AreEqual(expected.ToString(), Diamond.print(5));
    }
}