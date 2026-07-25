public class Product
{
    private string _name;
    private string _productID;
    private double _price;
    private int _quantity;

    public Product(string name, string productID, double price, int quantity)
    {
        _name = name;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }
    public string GetName()
    {
        return _name;
    } 
    public void SetName(string name)
    {
        _name = name;
    } 

    public string GetProductID()
    {
        return _productID;
    } 
    public void SetProductID(string id)
    {
        _productID = id;
    } 
    public double GetPrice()
    {
        return _price;
    } 
    public void SetPrice(double price)
    {
        _price = price;
    } 
    public int GetQuantity()
    {
       return _quantity;
    }
    public void SetQuantity(int quantity) 
    {
        _quantity = quantity;
    }
    public double TotalCost()
    {
        return _price * _quantity;
    }
}