using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Facade
{
    public class OrderService
    {
        public void Order(OrderRequest orderRequest)
        {
            var orderReq = new OrderRequest();

            var auth = new Authenticate();

            var inventory = new Inventory();
            foreach (var id in orderReq.ItemIds)
            {
                inventory.CheckInventory(id);
            }

            var payment = new Payment(orderReq.Name, orderReq.CardNumber, orderReq.Amount);
            payment.Pay();

            var orderFulFillment = new OrderFulfillment(inventory);
            orderFulFillment.Fulfill(orderReq.Name, orderReq.Address, orderReq.ItemIds);
        }
    }
}
