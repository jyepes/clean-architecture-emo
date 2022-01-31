namespace Northwind.Sales.BusinessObjects.Interfaces.Repositories
{
    public interface INorthwindSalesCommandsRepository: IUnitOfWork
    {
        ValueTask CreateOrder(OrderAggregate order);
    }
}
