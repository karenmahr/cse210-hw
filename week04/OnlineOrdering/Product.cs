//ATRIBUTE: Contains the name, product id, price, and quantity of each product. 
//METHOD: The total cthe price per unit and the quantity. (If the price per unit was $3 and they bought 5 of them, the product total cost would be $15.)
//THIS IS THE EASIESTS CLASSost of this product is computed by multiplying 
using System.Reflection.Metadata.Ecma335;

class Product
{
    private string _name;
    private int _id;
    private int _price;
    private int _quantity;

    public Product(string name, int id, int price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }
    private int TotalCost => _price * _quantity;

    public int GetTotalCost()
    {
        return TotalCost;
    }

    public int GetPrice()
    {
        return TotalCost;
    }    

    public int GetId()
    {
        return _id;
    }

}