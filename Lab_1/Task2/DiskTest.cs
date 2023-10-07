namespace Lab_1;

public class DiskTest<T> where T: TDisk, new()
{
  private T _testableInstance;
  
  public DiskTest(T disk)
  {
    _testableInstance = disk;
    Helpers.LogResult($"{_testableInstance}");
  }

  public void Execute()
  {
    string userInput = "";

    Helpers.LogMenu();
    
    Dictionary<string, Action> diskMenu = new Dictionary<string, Action>
    {
      { "1", TestParamsConstructor },
      { "2", TestCopyConstructor },
      { "3", TestDefaultConstructor },
      { "4", TestSetRadius },
      { "5", TestSetCenter },
      { "6", TestHasPoint },
      { "7", TestMultiplication },
    };

    while (userInput != "0")
    {
      userInput = Console.ReadLine();

      if (diskMenu.ContainsKey(userInput))
      {
        diskMenu[userInput].Invoke();
      }
    }
  }

  private void TestParamsConstructor()
  {
    Console.WriteLine("\tEnter _testableInstance params via space");
    double[] props = Array.ConvertAll(Console.ReadLine()!.Trim().Split(), double.Parse);
  
    _testableInstance = (T)Activator.CreateInstance(typeof(T), props)!;

    Helpers.LogResult($"{_testableInstance}");
  }
  
  private void TestCopyConstructor() 
  {
    Console.WriteLine("\tEnter copy _testableInstance params via space");
    double[] props = Array.ConvertAll(Console.ReadLine()!.Trim().Split(), double.Parse);
  
    T newDisk = (T)Activator.CreateInstance(typeof(T), props)!;
    _testableInstance = (T)Activator.CreateInstance(typeof(T), newDisk)!;
    
    Helpers.LogResult($"{_testableInstance}");
  }
  
  private void TestDefaultConstructor()
  {
    _testableInstance = new T();
    
    Helpers.LogResult($"{_testableInstance}");
  }
  
  private void TestSetRadius()
  {
    Console.WriteLine("\tEnter radius");
    double radius = double.Parse(Console.ReadLine()!);
    _testableInstance.SetRadius(radius);
    
    Helpers.LogResult($"{_testableInstance}");
  }
  
  private void TestSetCenter()
  {
    Console.WriteLine("\tEnter center point coordinates");
    double[] coordinates = Array.ConvertAll(Console.ReadLine()!.Trim().Split(), double.Parse);
    _testableInstance.SetCenter(coordinates);
    
    Helpers.LogResult($"{_testableInstance}");
  }
  
  private void TestHasPoint()
  {
    Console.WriteLine("\tEnter point coordinates");
    double[] coordinates = Array.ConvertAll(Console.ReadLine()!.Trim().Split(), double.Parse);
    
    Helpers.LogResult($"\t{_testableInstance.HasPoint(coordinates)}");
  }
  
  private void TestMultiplication()
  {
    Console.WriteLine("\tEnter multiply value");
    double value = double.Parse(Console.ReadLine()!);
    
    Helpers.LogResult($"\t_testableInstance * value: {_testableInstance * value}\n\tvalue * _testableInstance: {value * _testableInstance}");
  }
}