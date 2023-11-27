using System.Collections.Generic;

namespace Shop;

public static class ShopManager
{
    private static List<Product> products = new();

    public static void Sell(string barcode, double quantity)
    {
        Product product = products.Find(p => p.Barcode == barcode);
        if (product == null)
        {
            throw new Exception("Product not found");
        }

        if (product.Quantity < quantity)
        {
            throw new Exception("Not enough quantity");
        }

        product.Quantity -= quantity;
    }

    public static void Add(string barcode, string name, double price, double quantity)
    {
        Product product = products.Find(p => p.Barcode == barcode);
        if (product != null)
        {
            throw new Exception("Product already exists");
        }

        products.Add(new Product()
        {
            Barcode = barcode,
            Name = name,
            Price = price,
            Quantity = quantity
        });
    }

    public static void Update(string barcode, double quantity)
    {
        Product product = products.Find(p => p.Barcode == barcode);
        if (product == null)
        {
            throw new Exception("Product not found");
        }

        product.Quantity += quantity;
    }

    public static void PrintAvailable()
    {
        foreach (Product product in products)
        {
            if (product.Quantity > 0)
            {
                Console.WriteLine(product.ToString());
            }
        }
    }

    public static void PrintUnavailable()
    {
        foreach (Product product in products)
        {
            if (product.Quantity == 0)
            {
                Console.WriteLine(product.ToString());
            }
        }
    }

    public static void PrintDescending()
    {
        var ordered = products.OrderByDescending(p => p.Quantity);

        foreach (Product product in ordered)
        {
            Console.WriteLine(product.ToString());
        }
    }

    public static double Calculate()
    {
        return products.Sum(p => p.Price * p.Quantity);
    }
}