using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clean_Code_Functions
{
    partial class Blocks_Indenting
    {
        public double SamplePriceCalculator_Cleaned(Order order, Customer customer)
        {
            CheckItemsAvilablity(order);

            double discountRate = getCustomerFinalDiscountRate(customer);

            return order.TotalPrice * discountRate;
        }

        private double getCustomerFinalDiscountRate(Customer customer)
        {
            double discountRate = getCustomerBaseDiscount(customer);
            discountRate *= getDiscountBasedOnCustomerHistory(customer);
            return discountRate;
        }

        private double getDiscountBasedOnCustomerHistory(Customer customer)
        {
            List<Order> customerOrderHistory = GetCustomerHistory(customer);
            double extraDiscountRatio = 1;

            extraDiscountRatio *= getExtraDiscountRateBasedOnOrderCount(customerOrderHistory);
            extraDiscountRatio *= getExtraDiscountRateBasedOnOrderItemQuantity(customerOrderHistory);
            extraDiscountRatio *= getExtraDiscountRateBasedOnExpensiveOrderItems(customerOrderHistory);

            return extraDiscountRatio;
        }

        private static double getExtraDiscountRateBasedOnOrderCount(List<Order> customerOrderHistory)
        {
            if (customerOrderHistory.Count > 10)
                return 0.97;
            return 1;
        }

        private static double getExtraDiscountRateBasedOnExpensiveOrderItems(List<Order> customerOrderHistory)
        {
            double ordersContainingExpensiveItems = 0;
            foreach (Order prevOrder in customerOrderHistory)
            {
                if (prevOrder.OrderItems.Any(x => x.Product.Price > 100))
                {
                    ordersContainingExpensiveItems++;
                }
            }
            if (ordersContainingExpensiveItems / customerOrderHistory.Count > 0.5)
                return 0.98;
            return 1;
        }

        private static double getExtraDiscountRateBasedOnOrderItemQuantity(List<Order> customerOrderHistory)
        {
            double highQuantityOrders = 0;
            foreach (Order prevOrder in customerOrderHistory)
            {
                if (prevOrder.OrderItems.Count > 5)
                {
                    highQuantityOrders++;
                }
            }
            if (highQuantityOrders / customerOrderHistory.Count > 0.5)
                return 0.98;
            return 1;
        }

        private void CheckItemsAvilablity(Order order)
        {
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
        }
    }
}