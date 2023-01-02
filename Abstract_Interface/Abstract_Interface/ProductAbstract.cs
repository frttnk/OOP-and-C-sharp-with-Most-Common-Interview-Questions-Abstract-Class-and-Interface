namespace Abstract_Interface;

public abstract class ProductAbstract
{
    public ProductAbstract()
    {

    }
    private string? _productName;
    public string? ProductName
    {
        get { return _productName; }
        set { _productName = value; }
    }
    public abstract decimal ReturnPrice();

    public string ReturnProductName()
    {
        return ProductName ?? "";
    }

    public void TypeOfProduct()
    {
        Console.Write("Type of product"); // you cannot change this from the derived class
    }

}
