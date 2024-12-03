namespace ExtensionsDemo.ClassLib;

public static class LongExtensions
{
  public static bool IsPrime(this long source)
  {
    var result = true;

    if (source <= 1 || source % 2 == 0 || source % 3 == 0)
      result = false;

    else if (source <= 3 || source == 2)
      result = true;

    else
    {
      int i = 5;

      while (i * i <= source && !result)
      {
        if (source % i == 0 || source % (i + 2) == 0)
          result = false;

        i += 6;
      }
      result = true;
    }
    return result;
  }
}