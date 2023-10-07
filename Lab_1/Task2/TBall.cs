namespace Lab_1;

public class TBall : TDisk
{
  private double _cZ;

  public double cZ
  {
    get => _cZ;
  }

  public TBall(params double[] args) : base (args[0], args[1], args[2])
  {
    _cZ = args[3];
  }

  public TBall(TBall ball) : base(ball)
  {
    _cZ = ball.cZ;
  }

  public TBall()
  {
    _cZ = 0;
  }
  
  public override TBall SetCenter(params double[] coords)
  {
    if (coords.Length != 3)
    {
      throw new ArgumentOutOfRangeException();
    }

    _cX = coords[0];
    _cY = coords[1];
    _cZ = coords[2];

    return this;
  }
  
  public override double Square()
  {
    return 4 * Math.PI * Radius * Radius;
  }
  
  public override bool HasPoint(params double[] coords)
  {
    if (coords.Length != 3)
    {
      throw new ArgumentOutOfRangeException();
    }
    
    double difference1 = coords[0] - _cX;
    double difference2 = coords[1] - _cY;
    double difference3 = coords[2] - _cZ;
    double distance = Math.Sqrt(Math.Pow(difference1, 2) + Math.Pow(difference2, 2) + Math.Pow(difference3, 2));

    return distance <= Radius;
  }
  
  public override string ToString()
  {
    return $"\tRadius: {Radius}\n\tCenter: <{_cX} {_cY} {_cZ}>";
  }
}