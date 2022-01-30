

namespace Northwind.Sales.BusinessObjects.Interfaces.Presenters
{
    public interface ICreateOrderPresenter: ICreateOrderOutputPort
    {
        public int OrderId { get; }
    }
}
