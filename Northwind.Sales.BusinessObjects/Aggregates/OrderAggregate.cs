﻿namespace Northwind.Sales.BusinessObjects.Aggregates
{
    public class OrderAggregate: Order
    {
        readonly List<OrderDetail> OrderDetailsField = new List<OrderDetail>();
        public IReadOnlyCollection<OrderDetail> OrderDetails => OrderDetailsField;

        public void AddDetail(OrderDetail orderDetail)
        {
            var ExistingOrderDetail = OrderDetailsField
                .FirstOrDefault(o => o.ProductId == orderDetail.ProductId);

            if (ExistingOrderDetail != default)
            {
                OrderDetailsField.Add(ExistingOrderDetail with
                {
                    Quantity = (short)(ExistingOrderDetail.Quantity + orderDetail.Quantity)
                });
                OrderDetailsField.Remove(ExistingOrderDetail);
            }
            else
            {
                OrderDetailsField.Add(orderDetail);
            }
        }

        public void AddDetail(int productId, decimal unitPrice, short quantity)
        {
           AddDetail(new OrderDetail { Quantity = quantity, ProductId=productId, UnitPrice=unitPrice });
        }
    }
}
