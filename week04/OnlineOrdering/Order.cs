using System.Collections.Generic;
class Order
{
    private List<Product> _products;
    private Customer _customer;
    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }    
    public bool IsInUSA(Address address)
    {
        return address.IsInUSA();
    }
    private int ShippingCost()  
    {   
        int shippingCost;
        {
            if (_customer.IsInUSA())
            {
                shippingCost = 5;
            }
            else
            {
                shippingCost = 35;
            }
            return shippingCost;
        }
    }    
    private int TotalFinalCost()
    {
        int totalCost = 0;
        foreach (var product in _products)
        {
            totalCost += product.GetTotalCost();
        }
        return totalCost + ShippingCost();
    }

        public int GetTotalFinalCost()
        {
            return TotalFinalCost();
        }

    private string PackingLabel()
    {
        string label = "Packing Label:";
        foreach (var product in _products)
        {
            label += $"{product.GetName()} (ID: {product.GetId()})";
        }
        return label;
    }
        public string GetPackingLabel()
        {
            return PackingLabel();
        }

    private string ShippingLabel()
    {
        return $"Shipping Label: Name: {_customer.GetName()} {_customer.GetFullAddress()}";
    }
        public string GetShippingLabel()
        {
            return ShippingLabel();
        }
    
} 

