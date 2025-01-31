//ATTRIBUTE: The customer contains a name and an address. The name is a string, but the Address is a class.
//METHOD: The customer should have a method that can return whether they live in the USA or not. (Hint this should call a method on the address to find this.)

class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }    

    public string GetName()
    {
        return _name;
    }
    public bool IsInUSA()
    {
        return _address.IsInUSA();
    }

}
        
