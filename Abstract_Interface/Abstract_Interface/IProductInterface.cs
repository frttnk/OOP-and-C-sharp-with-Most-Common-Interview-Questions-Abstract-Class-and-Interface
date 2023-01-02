namespace Abstract_Interface;

public interface IProductInterface
{
    //public IProductInterface()
    //{

    //}
    decimal ReturnPrice();
    string ReturnProductName();
    void TypeOfProduct();

    void TestDefinition()
    {
        // default interface method. This method will never break your functionality
    }
}


