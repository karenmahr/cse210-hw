//ATRIBUTE: Contains the name, product id, price, and quantity of each product. 
//METHOD: The total cost of this product is computed by multiplying the price per unit and the quantity. (If the price per unit was $3 and they bought 5 of them, the product total cost would be $15.)
//THIS IS THE EASIESTS CLASS
class Product
{
    private string _name;
    private int _id;
    private int _price;
    private int _quantity;

    private int TotalCost => _price * _quantity;
 
}