namespace DecodeTheWoofs
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(WoofDecoder(""));
    }

    public static string WoofDecoder(string woof)
    {
      string[] newWord = woof.Split("!");

      char[] alphabet =  {
        'a', 'b', 'c', 'd', 'e', 'f',
        'g', 'h', 'i', 'j', 'k', 'l',
        'm', 'n', 'o', 'p', 'q', 'r',
        's', 't', 'u', 'v', 'w', 'x',
        'y', 'z'
      };
      string dogSays = " ";

      int x = 0;

      for (int i = 0; i < newWord.Length - 1; i++)
      {
        x = newWord[i].Split('-').Length;
      }

      if (x < alphabet.Length)
      {
        for (int i = 0; i < newWord.Length; i++)
        {
          if (newWord[i].ToLower().Contains('w') && newWord[i].ToLower().Contains('o') && newWord[i].ToLower().Contains('f'))
          {
            int z = newWord[i].Split('-').Length;
            char letter = alphabet[z - 1];
            dogSays += letter;
          }
          else if (!woof.Contains('w') && !woof.Contains('o') && !woof.Contains('f'))
          {
            return "nothing to decode!";
          }
          else if (dogSays == "" || dogSays.Length <= 0)
          {
            return "nothing to decode!";
          }
        }
      }
      else if (x > alphabet.Length)
      {
        return "just barking!";
      }

      return dogSays.Trim();
    }
  }
}