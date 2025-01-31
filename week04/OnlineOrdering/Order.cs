using System.Collections.Generic;
class Order
{
    private List<string> product;
    private string _customer;
    public Order(string customer)
    {
        _customer = customer;
        product = new List<string> { "milk", "bread", "eggs", "cheese", "tomato", "onion" };
    }
    public bool IsInUSA(Address address)
    {
        return address.IsInUSA();
    }
    public int ShippingCost(Address address)  
    {   
        int shippingCost;
        {
            if (address.IsInUSA())
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
        private int TotalFinalCost (int TotalCost, int ShippingCost) 
        {
            return TotalCost + ShippingCost;
        }

        private string PackingLabel(string _name, int _id)
        {
            return $"Name: {_name} Product ID: {_id}";
        }

        private string ShippingLabel(string _name, string CompleteAddress)
        {
            return $"Name: {_name} Complete Address: {CompleteAddress}";
        }
    
} 

