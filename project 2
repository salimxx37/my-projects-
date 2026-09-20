public class Vihicle
{
    public string Type;
    public string Brand;
    public int Year;
    public Vihicle(string type, string brand,int year)
    {
        Type = type;
        Brand = brand;
        Year = year;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Vihicle information");
        Console.WriteLine($"Type: {Type}");
        Console.WriteLine($"brand: {Brand}");
        Console.WriteLine($"Year/Model: {Year}");
     }
    public void Start()
    {
        Console.WriteLine($"The {Type} from {Brand} model {Year} is starting.");
        Console.WriteLine("ـــــــــــــــــــــــ");

    }
}
public class Car : Vihicle
{
    public int NumberOfDoors;
    public Car(string type, string brand, int year, int numberOfDoors) : base(type, brand, year)
    {
        NumberOfDoors = numberOfDoors;
    }
    public void DisplayCarInfo()
    {
        DisplayInfo();
        Console.WriteLine($"Number of Doors: {NumberOfDoors}");
        Console.WriteLine("ـــــــــــــــــــــــ");

    }
}
public class Bus:Vihicle
{
    public int Capacity;
    public Bus(string type, string brand, int year, int capacity) : base(type, brand, year)
    {
        Capacity = capacity;
    }
    public void DisplayBasInfo()
    {
        DisplayInfo();
        Console.WriteLine($"Capacity: {Capacity}");
        Console.WriteLine("ـــــــــــــــــــــــ");
    }
}
public class Bike : Vihicle
{
    public bool HasCarrier;
    public Bike(string type, string brand, int year, bool hasCarrier) : base(type, brand, year)
    {
        HasCarrier = hasCarrier;
    }
    public void DisplayBikeInfo()
    {
        DisplayInfo();
        Console.WriteLine($"Has Carrier: {HasCarrier}");
        Console.WriteLine("ـــــــــــــــــــــــ");

    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Car car = new Car("Car", "Toyota", 2025, 2);
        car.DisplayCarInfo();
        car.Start();
        Console.WriteLine();
        Bus bus = new Bus("Bus", "Hyundai", 2012, 12);
        bus.DisplayBasInfo();
        bus.Start();
        Console.WriteLine();
        Bike bike = new Bike("Bike", "Al-Raian", 2024, false);
        bike.DisplayBikeInfo();
        bike.Start();
    }
}
