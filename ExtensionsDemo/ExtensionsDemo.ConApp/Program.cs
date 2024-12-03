using ExtensionsDemo.ClassLib;
namespace ExtensionsDemo.ConApp;

internal class Program
{
  static void Main()
  {
    Console.WriteLine("Hello, World!");

    var text = "Jan1232435ksdf";
    var number = text.ToNumber();
    var number2 = text.LinqToNumber();

    // STRING Extensions Tests:
    Console.WriteLine($" Die Zahl aus dem Text ist: {number}\n");
    Console.WriteLine($" Die Zahl aus dem Text ist: {number2}");

    Console.WriteLine("\n\n");

    // LONG Extensions Tests:
    for (long i = 1 ; i < 1_000 ; i++)
      Console.Write(i.IsPrime() ? $"{i} ist Prime\n" : $"{i} ist kein Prime\n");

    // IENUMERABLE Extensions Tests:
    Console.WriteLine(text);
    text.Foreach(c => Console.WriteLine(c));

    Console.WriteLine("\n\n");

    foreach (var item in text.Filter(c => char.IsLower(c)))
      Console.WriteLine(item);

    List<int> list = [ 1 , 2 , 3 , 5 , 6 , 7 , 8 , 9 , 10 ];

    Console.WriteLine("\n\n");

    foreach (var item in list.Filter(e => e % 2 == 0).Filter(e => e > 5))
      Console.WriteLine(item);

    Console.WriteLine("SkipTo-Test: \n");

    foreach (var item in text.SkipTo(2))
      Console.Write(item);
  }
}