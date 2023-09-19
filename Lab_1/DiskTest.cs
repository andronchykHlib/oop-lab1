namespace Lab_1;

public class DiskTest<T> where T: TDisk, new()
{
  private T _testableInstance;
  
  public DiskTest(T disk)
  {
    _testableInstance = disk;
    Console.WriteLine(_testableInstance.ToString());
  }

  public void TestParamsConstructor()
  {
    Console.WriteLine("Enter _testableInstance params via space");
    double[] props = Array.ConvertAll(Console.ReadLine().Trim().Split(), double.Parse);
  
    _testableInstance = (T)Activator.CreateInstance(typeof(T), props);
    
    Console.WriteLine(_testableInstance.ToString());
  }
  
  public void TestCopyConstructor() 
  {
    Console.WriteLine("Enter copy _testableInstance params via space");
    double[] props = Array.ConvertAll(Console.ReadLine().Trim().Split(), double.Parse);
  
    TDisk newDisk = (T)Activator.CreateInstance(typeof(T), props);
    _testableInstance = (T)Activator.CreateInstance(typeof(T), newDisk);
    
    Console.WriteLine(_testableInstance.ToString());
  }
  
  public void TestDefaultConstructor()
  {
    _testableInstance = new T();
    
    Console.WriteLine(_testableInstance.ToString());
  }
  
  public void TestSetRadius()
  {
    Console.WriteLine("Enter radius");
    double radius = double.Parse(Console.ReadLine());
    _testableInstance.SetRadius(radius);
    
    Console.WriteLine(_testableInstance.ToString());
  }
  
  public void TestSetCenter()
  {
    Console.WriteLine("Enter center point coordinates");
    double[] coordinates = Array.ConvertAll(Console.ReadLine().Trim().Split(), double.Parse);
    _testableInstance.SetCenter(coordinates);
    
    Console.WriteLine(_testableInstance.ToString());
  }
  
  public void TestHasPoint()
  {
    Console.WriteLine("Enter point coordinates");
    double[] coordinates = Array.ConvertAll(Console.ReadLine().Trim().Split(), double.Parse);
    
    Console.WriteLine(_testableInstance.HasPoint(coordinates));
  }
  
  public void TestMultiplication()
  {
    Console.WriteLine("Enter multiply value");
    double value = double.Parse(Console.ReadLine());
    
    Console.WriteLine($"_testableInstance * value: {_testableInstance * value}");
    Console.WriteLine($"value * _testableInstance: {value * _testableInstance}");
  }
}