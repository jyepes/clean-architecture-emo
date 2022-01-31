namespace Northwind.Sales.BusinessObjects.ValueObjects
{
    //public class OrderDetail
    //{
    //    public int ProductId { get; set; }
    //    public decimal UnitPrice { get; set; }
    //    public short Quantity { get; set; }
    //}

    public record struct OrderDetail(int ProductId, decimal UnitPrice, short Quantity);
}
