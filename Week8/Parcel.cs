namespace Week8;

public class Parcel : DeliveryItem
{
    public string Dimensions { get; private set; }

    public Parcel(string trackingnumber, double weight, string dimensions) : base(trackingnumber, weight)
    {
        Dimensions = dimensions;
    }

    public override double CalculateCost()
    {
        return 50 + (Weight * 25);
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Габарити: {Dimensions}");
    }
}