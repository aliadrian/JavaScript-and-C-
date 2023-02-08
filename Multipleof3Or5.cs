namespace Multiple3or5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Multiple3or5(10));
        }
        public static int Multiple3or5(int number)
        {
            // This code includes the number 10 (which is a multiple of 5)
            // 10 + 9 + 6 + 5 + 3 = 33
            int res;

            if (number < 0)
            {
                return 0;
            }
            else
            {
                if (number % 3 == 0 || number % 5 == 0)
                {
                    res = number + Multiple3or5(number - 1);
                    return res;
                }
                else
                {
                    res = Multiple3or5(number - 1);
                    return res;
                }
            }

            // This doesn't include the multiple of 5
            // 9 + 6 + 5 + 3 = 23

            //int sum = 0;

            //for (int i = 0; i < number; i++)
            //{
            //	if (i % 3 == 0 || i % 5 == 0)
            //	{
            //		sum += i;
            //		continue;
            //	} 
            //	else
            //	{
            //		continue;
            //	}
            //}
            //return sum;
        }
    }
}