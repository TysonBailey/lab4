using System;
using System.IO;
using System.Net;
using System.Xml.Linq;
using System.Collections;
using static System.Net.WebRequestMethods;

string root = FileRoot.Root;
string csvFile = root + Path.DirectorySeparatorChar + "data.csv";
string psvFile = root + Path.DirectorySeparatorChar + "data.psv";

List<Person> people = new List<Person>();
List<Address> addresses = new List<Address>();



using (var sr = new StreamReader(csvFile))
{
    while (!sr.EndOfStream)
    {
        int num = 0;
        string line = sr.ReadLine();
        var info = line.Split(",");

        var firstName = info[0];
        var lastName = info[1];
        var street = info[2];
        var city = info[3];
        var state = info[4];
        var postalCode = info[5];

        addresses.Add(new Address(street, city, state, postalCode));
        people.Add(new Person(firstName, lastName, addresses[num]));
        people.Sort();
        num++;
    }
}

using (var sw = new StreamWriter(psvFile, append: false))
{
    foreach (Person p in people)
    {
        Console.WriteLine(p.ToString);
        string line = $"{p.firstName} |{p.lastName}|{p.address.street}|{p.address.city}|{p.address.state}|{p.address.postalCode}";
        sw.WriteLine(line);
    }
}

public class FileRoot
{
    public static string Root = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.ToString();

}

