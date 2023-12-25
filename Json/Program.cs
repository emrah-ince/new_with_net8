using System.Text.Json;

IGeo circile = new Circle { Pi = 3.141592, R = 2 };
var jsonCircile = JsonSerializer.Serialize(circile);
Console.WriteLine("Circile Json: " + jsonCircile);

IGeo square = new Square { X = 5 };
var jsonSquare = JsonSerializer.Serialize(square);
Console.WriteLine("Square Json: " + jsonSquare);


public interface IBaseMath
{
    public double? Pi { get; set; }
    public string Type { get; set; }
}
public interface IGeo : IBaseMath
{
    public int X { get; set; }
    public int Y { get; set; }
    public int? H { get; set; }
    public double? R { get; set; }
    public double? FindArea();
    public double? FindPerimeter();
}
public class Square : IGeo
{
    int x, y;
    int? h;
    double? r;
    string type;
    public double? Pi { get; set; }
    public int X { get => x; set => x = value; }
    public int Y { get => y; set => y = value; }
    public int? H { get => h; set => h = value; }
    public double? R { get => r; set => r = value; }
    public string Type { get => type; set => type = value; }

    public double? FindArea()
    {
        return Math.Pow(X, 2);
    }

    public double? FindPerimeter()
    {
        return 4 * X;
    }
}
public class Circle : IGeo
{
    double? pi;
    public double? Pi { get { return pi; } set { pi = value; } }

    int x, y;
    int? h;
    double? r;
    string type;
    public int X { get => x; set => x = value; }
    public int Y { get => y; set => y = value; }
    public int? H { get => h; set => h = value; }
    public double? R { get => r; set => r = value; }
    public string Type { get => type; set => type = value; }

    public double? FindArea(int x, int? h, double? r)
    {
        return pi * Math.Pow((double)r, 2);
    }

    public double? FindArea()
    {
        throw new NotImplementedException();
    }

    public double? FindPerimeter()
    {
        return 2 * Pi * R;
    }
}