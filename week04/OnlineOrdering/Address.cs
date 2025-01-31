//ATTRIBUTE: The address contains a string for the street address, the city, state/province, and country. Escribo cada cosa por separado y el ultimo metodo lo junta
//METHOD: The address should have a method that can return whether it is in the USA or not. -Connects with Customer
//METHOD: The address should have a method to return a string all of its fields together in one string (with newline characters where appropriate)

class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _streetAddress = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool IsInUSA()
    {
        return _country == "USA";
    }
    private string CompleteAddress()
    {
        return $"{_streetAddress}, {_city}, {_state}, {_country}";
    }
    public string GetFullAddress()
    {
        return CompleteAddress();
    }
    
}
