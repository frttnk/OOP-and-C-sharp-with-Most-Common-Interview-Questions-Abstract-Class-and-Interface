namespace Abstract_Interface;

public class LaptopProduct : ProductAbstract,IProductInterface, IBasketInterface
{
    public override decimal ReturnPrice()
    {
        throw new NotImplementedException();
    }

    public void TypeOfProduct() // coming from IProductInterface
    {
        throw new NotImplementedException();
        // you can put your logic here 
    }
}







