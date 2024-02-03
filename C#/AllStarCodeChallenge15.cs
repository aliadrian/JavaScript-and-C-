namespace AllStarCodeChallenge
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(Rotate("Hello"));
    }

    public static List<string> Rotate(string str)
    {
      List<string> result = new List<string>();

      for (int i = 0; i < str.Length; i++)
      {
        result.Add(str.Substring(i + 1) + str.Substring(0, i + 1));
      }

      return result;
    }
  }
}