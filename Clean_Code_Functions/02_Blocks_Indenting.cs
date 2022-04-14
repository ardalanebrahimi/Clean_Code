using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clean_Code_Functions
{
    partial class Blocks_Indenting
    {
        public double SamplePriceCalculator(Order order, Customer customer)
        {
            double discountRate = getCustomerBaseDiscount(customer);
            List<Order> customerOrderHistory = GetCustomerHistory(customer);

            if (customerOrderHistory.Count > 10)
                discountRate = discountRate * 0.97;

            double highQuantityOrders = 0;
            double ordersContainingExpensiveItems = 0;
            foreach (Order prevOrder in customerOrderHistory)
            {
                if (prevOrder.OrderItems.Count > 5)
                {
                    highQuantityOrders++;
                }

                if (prevOrder.OrderItems.Any(x => x.Product.Price > 100))
                {
                    ordersContainingExpensiveItems++;
                }
            }
            if (highQuantityOrders / customerOrderHistory.Count > 0.5)
                discountRate = discountRate * 0.98;
            if (ordersContainingExpensiveItems / customerOrderHistory.Count > 0.5)
                discountRate = discountRate * 0.98;

            foreach (OrderItems orderItem in order.OrderItems)
            {
                int inventoryQuantity = getInventoryAvailableQuanty(orderItem.Product);
                int inStoreQuantity = getCustomerBaseDiscount(orderItem.Quantity);
                if (orderItem.Quantity > inventoryQuantity)
                {
                    if (orderItem.Quantity > inStoreQuantity)
                    {
                        if (orderItem.Quantity > inventoryQuantity + inStoreQuantity)
                        {
                            throw (new Exception(orderItem.Product.Name + "Item out of stock"));
                        }
                    }
                }

                int quantityInOpenOrders = GetCurrentTotalOrders(orderItem.Product);
                if (quantityInOpenOrders > inventoryQuantity + inStoreQuantity)
                    throw (new Exception(orderItem.Product.Name + "Inventory shortage"));
            }

            return order.OrderItems.Sum(x => x.Product.Price * x.Quantity) * discountRate;
        }
    }
}