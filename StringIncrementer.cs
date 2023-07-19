public static string IncrementString(string s1)
{
  string numbers;
  string randomString;
  Regex regex = new Regex(@"(\d+)$");
  Match match = regex.Match(s1);

  if (match.Success)
  {
    numbers = match.Value;
    randomString = s1.Substring(0, match.Index);
  }
  else
  {
    return s1 + "1";
  }

  int sum = int.Parse(numbers) + 1;
  string paddedSum = sum.ToString().PadLeft(numbers.Length, '0');
  return randomString + paddedSum;
}