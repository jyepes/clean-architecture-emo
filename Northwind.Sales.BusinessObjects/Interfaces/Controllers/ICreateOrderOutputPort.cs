namespace Northwind.Sales.BusinessObjects.Interfaces.Controllers
{
    public interface ICreateOrderOutputPort
    {
        ValueTask Handle(int orderId);
    }
}
