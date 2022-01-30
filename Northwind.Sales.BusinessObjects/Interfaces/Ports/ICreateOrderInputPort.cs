namespace Northwind.Sales.BusinessObjects.Interfaces.Ports
{
    public interface ICreateOrderInputPort
    {
        ValueTask Handle(CreateOrderDTO OrderDTO);
    }
}
