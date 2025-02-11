using System;

class Vehicle
{
    public string Make { get; private set; }
    public string Model { get; private set; }
    public string EngineNumber { get; private set; }
    public decimal SalePrice { get; private set; }

    // Method to set vehicle details with user input
    public void SetVehicle()
    {
        Console.Write("Enter Vehicle Make: ");
        Make = Console.ReadLine();

        Console.Write("Enter Vehicle Model: ");
        Model = Console.ReadLine();

        Console.Write("Enter Engine Number: ");
        EngineNumber = Console.ReadLine();

        Console.Write("Enter Sale Price (KSH): ");
        SalePrice = Convert.ToDecimal(Console.ReadLine());
    }

    // Method to calculate profit
    public decimal GetProfit()
    {
        return SalePrice * 0.15m;
    }

    // Method to display vehicle details
    public void DisplayVehicle()
    {
        Console.WriteLine($"\nVehicle Details:");
        Console.WriteLine($"Make: {Make}, Model: {Model}, Engine Number: {EngineNumber}, Sale Price: {SalePrice:N2} KSH, Profit: {GetProfit():N2} KSH");
    }
}

class Program
{
    static void Main()
    {
        Vehicle car = new Vehicle();
        car.SetVehicle();
        car.DisplayVehicle();
    }
}
