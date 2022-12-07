using System;

public class Address
{
    public string street;
    public string city;
    public string state;
    public string postalCode;
    public override string ToString()
    {
        return $"{{{street} | {city} | {state} | {postalCode} }}";
    }
    public Address(string street, string city, string state, string postalCode)
    {
        this.street = street;
        this.city = city;
        this.state = state;
        this.postalCode = postalCode;
    }
}