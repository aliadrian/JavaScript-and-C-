using System.Text.RegularExpressions;

namespace Kebabize
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(Kebabize("myCamelCasedString"));
    }

    public static string Kebabize(string s)
    {
      var newString = Regex.Replace(s, @"\d", "");
      string[] split = Regex.Split(newString, @"(?<!^)(?=[A-Z])");
      string camelCased = string.Empty;

      foreach (var c in split)
      {
        camelCased += c + "-";
      }

      return camelCased.Substring(0, camelCased.Length - 1).ToLower();
    }
  }
}