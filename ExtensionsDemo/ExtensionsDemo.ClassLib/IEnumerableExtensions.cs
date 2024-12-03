namespace ExtensionsDemo.ClassLib;

public static class IEnumerableExtensions
{
  public static IEnumerable<T> Filter<T>(this IEnumerable<T> source , Func<T , bool> filter)
  {
    var result = new List<T>();

    foreach (var item in source)
      if (filter == null || filter(item))
        result.Add(item);
    return result;
  }

  public static IEnumerable<T> SkipTo<T>(this IEnumerable<T> source , int count = 0)
  {
    var result = new List<T>();
    int itemCount = 0;

    foreach (var item in source)
    {
      if (itemCount >= count)
        result.Add(item);
      itemCount++;
    }
    return result;
  }
}