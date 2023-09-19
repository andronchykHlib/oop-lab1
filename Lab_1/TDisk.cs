namespace Lab_1;

public class TDisk
{
  public double cY { get; set; }

  public double cX { get; set; }

  public double Radius { get; set; }


  // Constructors
  public TDisk(params double[] args)
  {
    Radius = args[0];
    this.cX = args[1];
    this.cY = args[2];
  }

  public TDisk(TDisk disk)
  {
    Radius = disk.Radius;
    cX = disk.cX;
    cY = disk.cY;
  }

  public TDisk()
  {
    Radius = 2;
    cX = 0;
    cY = 0;
  }
  
  // Methods
  public TDisk SetRadius(double r)
  {
    Radius = r;
    
    return this;
  }

  public TDisk SetCenter(params double[] coords)
  {
    cX = coords[0];
    cY = coords[1];

    return this;
  }

  public double Square()
  {
    return Math.PI * Radius * Radius;
  }

  public bool HasPoint(params double[] coords)
  {
    var difference1 = coords[0] - cX;
    var difference2 = coords[1] - cY;
    var distance = Math.Sqrt(Math.Pow(difference1, 2) + Math.Pow(difference2, 2));

    return distance <= Radius;
  }

  public static double operator *(TDisk a, double b)
  {
    return a.Radius * b;
  }  
  
  public static double operator *(double a, TDisk b)
  {
    return a * b.Radius;
  }

  public override string ToString()
  {
    return $"Radius: {Radius}\nCenter: <{cX} {cY}>";
  }
}