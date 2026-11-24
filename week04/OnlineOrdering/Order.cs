public class Order
{
    private readonly Customer _customer;
    private readonly List<Product> _products;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = [];
    }
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public double GetTotalCost()
    {
        double totalCost = 0;
        foreach (Product product in _products)
        {
            totalCost += product.GetTotalCost();
        }
        if (!_customer.IsInUSA())
        {
            totalCost += 35;
        }
        else
        {
            totalCost += 5;
        }
        return totalCost;
    }
    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label:\n";
        foreach (Product product in _products)
        {
            packingLabel += $"{product.GetName()} - {product.GetProductID()}\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
    }
}
    