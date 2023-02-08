using System;

namespace SumIntegersInString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumIntegersInString("567abcdef567"));
        }

        static int SumIntegersInString(string input)
        {
            int sum = 0;
            string currentNumber = "";

            foreach (char c in input)
            {
                if (Char.IsDigit(c))
                {
                    currentNumber += c;
                }
                else
                {
                    if (currentNumber != "")
                    {
                        sum += int.Parse(currentNumber);
                        currentNumber = "";
                    }
                }
            }

            if (currentNumber != "")
            {
                sum += int.Parse(currentNumber);
            }

            return sum;
        }
    }
}


// better solution
// return Regex.Matches(s, "\\d+").Sum(x => int.Parse(x.Value));