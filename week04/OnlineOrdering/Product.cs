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
    public string GetName()
    {
        return _name;
    }    
    public int GetId()
    {
        return _id;
    }

}