using System.Numerics;
using System.Runtime.CompilerServices;

namespace Lab_1;

class SurfaceEquation
{
    private readonly Tuple<int, int,int, int> _coefficients = new(0, 0, 0, 0);
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
        _coordinates = Tuple.Create(coordinates[0], coordinates[1], coordinates[2]);

        return this;
    }

    public int[] GetAllCoefficients()
    {
        int[] coefficientsArray  = new int[4];
        
        Array.Copy(Array.ConvertAll(_coefficients.ToString().Split(), int.Parse), coefficientsArray, 4);
        
        return coefficientsArray;
    }

    public bool HasPoint(params int[] coordinates)
    {
        if (coordinates.Length == 0)
        {
            return _coefficients.Item1 * _coordinates.Item1 + _coefficients.Item2 * _coordinates.Item2 + _coefficients.Item3 * _coordinates.Item3 + _coefficients.Item4 == 0;
        }

        var (x, y, z) = (coordinates[0], coordinates[1], coordinates[2]);

        return _coefficients.Item1 * x + _coefficients.Item2 * y + _coefficients.Item3 * z + _coefficients.Item4 == 0;
    }

    public string Intersects(SurfaceEquation surface)
    {
        Vector3 normal1 = new Vector3(surface[0], surface[1], surface[2]);
        Vector3 normal2 = new Vector3(_coefficients.Item1, _coefficients.Item2, _coefficients.Item3);

        var direction = Vector3.Cross(normal1, normal2);

        if (direction.Length() == 0)
        {
            return "Parallel";
        }

        Vector3 point = (direction * surface[3] - direction * _coefficients.Item4) / (direction.LengthSquared());
        point.ToString();
        return  point.ToString();
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