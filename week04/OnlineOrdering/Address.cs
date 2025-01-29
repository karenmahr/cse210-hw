//ATTRIBUTE: The address contains a string for the street address, the city, state/province, and country. Escribo cada cosa por separado y el ultimo metodo lo junta
//METHOD: The address should have a method that can return whether it is in the USA or not. -Connects with Customer
//METHOD: The address should have a method to return a string all of its fields together in one string (with newline characters where appropriate)

class Address
{
    private string _streetaddress;
    private string _city;
    private string _state;
    private string _country;

    private string Location()
    {
        return _country;
    }

    private string CompleteAddress()
    {
        return $"{_streetaddress}, {_city}, {_state}, {_country}";
    }
}
