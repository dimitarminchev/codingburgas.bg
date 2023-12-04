namespace Shop;

public class Product
{
    private string name;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    
    private string barcode;
    public string Barcode
    {
        get { return barcode; }
        set { barcode = value; }
    }
    
    private double price;
    public double Price
    {
        get { return price; }
        set { price = value; }
    }
    
    private double quantity;
    public double Quantity
    {
        get { return quantity; }
        set { quantity = value; }
    }

    public override string ToString()
    {
        return $"{name} ({barcode})";
    }
}