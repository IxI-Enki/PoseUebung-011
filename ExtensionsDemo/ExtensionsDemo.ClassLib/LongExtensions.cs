namespace ExtensionsDemo.ClassLib;

public static class LongExtensions
{
  public static bool IsPrime(this long source)
  {
    if (source <= 1)
      return false;
    if (source <= 3)
      return true;
    if (source % 2 == 0 || source % 3 == 0)
      return false;

    int i = 5;

    while (i * i <= source)
    {
      if (source % i == 0 || source % (i + 2) == 0)
        return false;
      i += 6;
    }

    return true;
  }
}