using System.Text.RegularExpressions;

namespace ProofRead
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(ProofRead("HIs nieghBOur wAs oVerwieGht."));
    }

    public static string ProofRead(string s)
    {
      string[] array = s.ToLower().Split(' ');
      string modified = string.Empty;
      Regex regexCasing = new Regex("(?:[.:?!]\\s[a-z]|^(?:\\s+)?[a-z])", RegexOptions.Multiline);

      foreach (var item in array)
      {
        if (item.Contains("ie"))
        {
          modified += item.Replace("ie", "ei") + " ";
        }
        else
        {
          modified += item + " ";
        }
      }

      return regexCasing.Replace(modified, s => s.Value.ToUpper());
    }
  }
}