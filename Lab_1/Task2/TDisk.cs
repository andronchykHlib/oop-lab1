namespace Lab_1;

public class TDisk
{
  protected double _cY;

  protected double _cX;

  protected double _Radius;

  public double Radius
  {
    get => _Radius;
  }
  public double cY
  {
    get => _cY;
  }
  public double cX
  {
    get => _cX;
    set { }
  }


  // Constructors
  public TDisk(params double[] args)
  {
    _Radius = args[0];
    _cX = args[1];
    _cY = args[2];
  }

  public TDisk(TDisk disk)
  {
    _Radius = disk.Radius;
    _cX = disk.cX;
    _cY = disk.cY;
  }

  public TDisk()
  {
    _Radius = 2;
    _cX = 0;
    _cY = 0;
  }
  
  // Methods
  public virtual TDisk SetRadius(double r)
  {
    _Radius = r;
    
    return this;
  }

  public virtual TDisk SetCenter(params double[] coords)
  {
    _cX = coords[0];
    _cY = coords[1];

    return this;
  }

  public virtual double Square()
  {
    return Math.PI * Radius * Radius;
  }

  public virtual bool HasPoint(params double[] coords)
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
    return $"\tRadius: {Radius}\n\tCenter: <{cX} {cY}>";
  }
}