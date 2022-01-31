namespace Northwind.Sales.UseCases.CreateOrder
{
    public class CreateOrderInteractor : ICreateOrderInputPort
    {
        readonly INorthwindSalesCommandsRepository _repository;
        readonly ICreateOrderOutputPort _outputPort;

        public CreateOrderInteractor(INorthwindSalesCommandsRepository repository, ICreateOrderOutputPort outputPort)
        {
            _repository = repository;
            _outputPort = outputPort;
        }

        public async ValueTask Handle(CreateOrderDTO OrderDTO)
        {
            var orderAggregate = new OrderAggregate
            {
                CustomerId = OrderDTO.CustomerId,
                ShipAddress= OrderDTO.ShipAddress,
                ShipCity= OrderDTO.ShipCity,
                ShipCountry= OrderDTO.ShipCountry,
                ShipPostalCode= OrderDTO.ShipPostalCode               
            };
            foreach (var item in OrderDTO.OrderDetails)
            {
                orderAggregate.AddDetail(item.ProductId, item.UnitPrice, item.Quantity);
            }

            await _repository.CreateOrder(orderAggregate);
            await _repository.SaveChanges();
            await _outputPort.Handle(orderAggregate.Id);
        }
    }
}
