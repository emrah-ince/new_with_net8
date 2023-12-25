var i = 5;
System.Console.WriteLine(new Car().Name(ref i)); // C#11'de "Park" yazar ama C# 12'de "Car" yazar.
System.Console.WriteLine(CarExtension.Name(new Car(), ref i));
System.Console.WriteLine("".PadRight(80, '*'));

class Car
{
    public string Name(in int i) => "Car";
}
static class CarExtension
{
    public static string Name(this Car c, ref int i) => "Park";
}
