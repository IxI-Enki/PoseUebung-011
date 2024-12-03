namespace ExtensionsDemo.ClassLib;

public static class StringExtensions
{
  public static long ToNumber(this string source)
  {
    long result = 0;
    string digits = string.Empty;

    foreach (char c in source)
    {
      if (char.IsDigit(c))
        digits += c;

      if (digits.Length > 0)
        result = Convert.ToInt64(digits);
    }
    return result;
  }

  public static long LinqToNumber(this string source)
  {
    var result = default(long);
    var digits = string.Concat(source.Where(c => char.IsDigit(c)));

    if (digits.Length > 0)
      result = Convert.ToInt64(digits);

    return result;
  }

  public static bool IsNullOrEmpty(this string source) => string.IsNullOrEmpty(source);

  public static string Foreach(this string source , Action<char> action)
  {
    foreach (char c in source)
      action?.Invoke(c);

    return source;
  }
}