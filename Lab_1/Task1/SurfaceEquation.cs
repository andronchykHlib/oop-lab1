using System.Runtime.CompilerServices;

namespace Lab_1;

class SurfaceEquation
{
    private readonly Tuple<int, int,int, int> _coefficients;
    private Tuple<int, int,int> _coordinates = new (0, 0, 0);

    public SurfaceEquation(params int[] coefs)
    {
        if (coefs.Length != 4)
        {
            throw new ArgumentException($"Expected 4 elements to be provided, but received {coefs.Length}");
        }

        _coefficients = Tuple.Create(coefs[0], coefs[1], coefs[2], coefs[3]);
    }

    public SurfaceEquation SetCoordinates(params int[] coordinates)
    {
        if (coordinates.Length < 3)
        {
            throw new ArgumentException("Coordinates length is incorrect");
        }

        _coordinates = Tuple.Create(coordinates[0], coordinates[1], coordinates[2]);

        return this;
    }

    public string GetAllCoefficients() => _coefficients.ToString();
    
    public bool HasPoint(params int[]? coordinates)
    {
        if (coordinates == null || coordinates.Length == 0)
        {
            return _coefficients.Item1 * _coordinates.Item1 + _coefficients.Item2 * _coordinates.Item2 + _coefficients.Item3 * _coordinates.Item3 + _coefficients.Item4 == 0;
        }

        var (x, y, z) = (coordinates[0], coordinates[1], coordinates[2]);

        return _coefficients.Item1 * x + _coefficients.Item2 * y + _coefficients.Item3 * z + _coefficients.Item4 == 0;
    }

    public SurfaceEquation GetAxisIntersection()
    {
        var (a, b, c, d) = (_coefficients.Item1, _coefficients.Item2, _coefficients.Item3, _coefficients.Item4);
        
        if (a != 0)
        {
            double x = (double)-d / a;
            Console.WriteLine($"Intersects X axis at [{x},0,0]");
        }
        if (b != 0)
        {
            double y = (double)-d / b;
            Console.WriteLine($"Intersects Y axis at [0,{y},0]");
        }
        if (c != 0)
        {
            double z = (double)-d / c;
            Console.WriteLine($"Intersects Z axis at [0,0,{z}]");
        }

        return this;
    }

    public int this[int c] {
        get
        {
            if (c is > 4 or < 0)
            {
                return 0;
            }

            return (int)((ITuple)_coefficients)[c]!;
        }
    }
}   