// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



class Product
{
    public int Id;

    public string Description;

    public double Price;

    public string Currency;
}


abstract class Delivery
{
    public string Address;
}

class HomeDelivery : Delivery
{
    public double DeliveryPrice;
}

class PickPointDelivery : Delivery
{
    public double DeliveryPrice;
}

class ShopDelivery : Delivery
{
    public double DeliveryPrice;
}

class Order<TDelivery, TStruct> where TDelivery : Delivery
{
    public TDelivery Delivery;

    public int Number;

    public string Description;

    public List<Product> Products; 
    public void DisplayAddress()
    {
        Console.WriteLine(Delivery.Address);
    }
}