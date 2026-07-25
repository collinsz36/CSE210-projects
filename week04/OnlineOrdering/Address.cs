using System;
using System.Collections.Generic;

public class Address
{
    private string _street;
    private string _city;
    private string _province;
    private string _country;

    public Address(string street, string city, string province, string country)
    {
        _street = street;
        _city = city;
        _province = province;
        _country = country;
    }
    public string GetStreet()
    {
        return _street;
    }
    public void SetStreet(string street)
    {
        _street = street;
    } 
    public string GetCity()
    {
        return _city;
    } 
    public void SetCity(string city)
    {
        _city = city;
    }
   public string GetProvince()
    {
        return _province;
    }
    public void SetProvince(string province)
    {
        _province = province;
    } 
    public string GetCountry()
    {
        return _country;
    } 
   public void SetCountry(string country)
    {
        _country = country;
    }
    public string GetFullAddress()
    {
        return $"{_street}\n{_city}, {_province}\n{_country}";
    }
    public bool USAResident()
    {
        if (_country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }    
}
