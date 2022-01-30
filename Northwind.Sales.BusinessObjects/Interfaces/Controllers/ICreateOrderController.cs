namespace Northwind.Sales.BusinessObjects.Interfaces.Controllers
{
    public interface ICreateOrderController
    {
        ValueTask<int> CreateOrder(CreateOrderDTO order);
    }
}
