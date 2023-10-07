namespace Lab_1;

public class Helpers
{
  public static void LogMenu()
  {
    Console.ForegroundColor = ConsoleColor.Blue;  
    Console.WriteLine("\n\tMenu");
    Console.WriteLine("\t0 - Exit");
    Console.WriteLine("\t1 - Test params constructor");
    Console.WriteLine("\t2 - Test Copy Constructor");
    Console.WriteLine("\t3 - Test Default Constructor");
    Console.WriteLine("\t4 - Test Set Radius");
    Console.WriteLine("\t5 - Test Set Center");
    Console.WriteLine("\t6 - Test Has Point");
    Console.WriteLine("\t7 - Test Multiplication");
    Console.ForegroundColor = ConsoleColor.White;
  }

  public static void LogResult(string log)
  {
    Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine(log); Console.ForegroundColor = ConsoleColor.White; 
  }
}