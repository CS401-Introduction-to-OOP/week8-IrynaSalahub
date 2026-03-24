using Week8;

class program
{
    static void Main()
    {
        Letter letter1 = new Letter("1", 0.5);
        Letter letter2 = new Letter("2", 0.7);
        Parcel parcel1 = new Parcel("3", 3, "20x20x20");
        Parcel parcel2 = new Parcel("4", 4, "10x10x10");
        
        letter1.PrintInfo();
        parcel1.PrintInfo();

        CargoContainer<DeliveryItem> myCargo = new CargoContainer<DeliveryItem>();
        myCargo.AddItem(letter1);
        myCargo.AddItem(letter2);
        myCargo.AddItem(parcel1);
        myCargo.AddItem(parcel2);
        double totalcost = myCargo.GetTotalCost();
        Console.WriteLine(totalcost);
    }
}