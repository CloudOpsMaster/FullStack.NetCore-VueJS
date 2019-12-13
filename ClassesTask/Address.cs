

public class Address
{
    private int index;
    private string country;
    private string city;
    private string street;
    private int house;
    private int apartment;

    public int Index
    {
        get
        {
            return index;
        }
        set
        {
            index = value;
        }
    }
    public string Country
    {
        get
        {
            return country;
        }
        set
        {
            country = value;
        }
    }
    public string City
    {
        get
        {
            return city;
        }
        set
        {
            city = value;
        }
    }
    public string Street
    {
        get
        {
            return street;
        }
        set
        {
            street = value;
        }
    }
    public int House
    {
        get
        {
            return house;
        }
        set
        {
            house = value;
        }


    }
    public int Apartment
    {
        get
        {
            return apartment;
        }
        set
        {
            apartment = value;
        }
    }

    public Address()
    {

    }
    public Address(int index, string country, string city, string street, int house, int apartment)
    {
        Index = index;
        Country = country;
        City = city;
        Street = street;
        House = house;
        Apartment = apartment;
    }

}
