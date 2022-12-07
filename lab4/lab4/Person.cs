using System;

public class Person : IComparable<Person>
{
    public string firstName;
    public string lastName;
    public Address address;

    public override string ToString()
    {
        return $"{{{firstName} | {lastName} | {address.ToString} }}";
    }

    public int CompareTo(Person that)
    {
        return this.lastName.CompareTo(that.lastName);
    }

    public Person(string firstName, string lastName, Address address)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.address = address;
    }
}