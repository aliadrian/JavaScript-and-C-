using System.Text.RegularExpressions;

public static string ReverseVowels(string s)
{
  var regex = new Regex(@"[aeiouAEIOU]");
  List<char> vowels = new List<char>();
  string newString = "";

  foreach (var c in s)
  {
    if (regex.IsMatch(c.ToString()))
    {
      vowels.Add(c);
    }
  }

  vowels.Reverse();
  int i = 0;

  foreach (var c in s)
  {
    if (regex.IsMatch(c.ToString()))
    {
      newString += vowels[i];
      i++;
    }
    else
    {
      newString += c;
    }
  }

  return newString;
}
