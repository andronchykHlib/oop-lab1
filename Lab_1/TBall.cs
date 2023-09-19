namespace Lab_1;

public class TBall : TDisk
{
  public double cZ { get; set; }

  public TBall(params double[] args) : base (args[0], args[1], args[2])
  {
    cZ = args[3];
  }

  public TBall(TBall ball) : base(ball)
  {
    cZ = ball.cZ;
  }

  public TBall()
  {
    cZ = 0;
  }
  
  public TBall SetCenter(params double[] coords)
  {
    if (coords.Length != 3)
    {
      throw new ArgumentOutOfRangeException();
    }

    cX = coords[0];
    cY = coords[1];
    cZ = coords[2];

    return this;
  }
  
  public double Square()
  {
    return 4 * Math.PI * Radius * Radius;
  }
  
  public bool HasPoint(params double[] coords)
  {
    if (coords.Length != 3)
    {
      throw new ArgumentOutOfRangeException();
    }
    
    double difference1 = coords[0] - cX;
    double difference2 = coords[1] - cY;
    double difference3 = coords[2] - cZ;
    double distance = Math.Sqrt(Math.Pow(difference1, 2) + Math.Pow(difference2, 2) + Math.Pow(difference3, 2));

    return distance <= Radius;
  }
  
  public override string ToString()
  {
    return $"Radius: {Radius}\nCenter: <{cX} {cY} {cZ}>";
  }
}