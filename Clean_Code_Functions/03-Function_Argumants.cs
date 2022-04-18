using System;
using System.Collections.Generic;
using System.Text;

namespace Clean_Code_Functions
{
    class Function_Argument
    {
        #region Event methods
        public void LogError(string errorMessage)
        {
            Console.Write(errorMessage);
        }

        public void DisposeAll(List<IDisposable> responses)
        {
            responses.ForEach(response => response.Dispose());
        }
        #endregion

        #region Flag Atribute
        public void Finction1(bool isThis)
        {
            // Some Code (or none!)
            
            if (isThis)
            {
                ; // DO THIS OP
            }
            else
            {
                ; // DO THAT OP
            }

            //Some more code (or none!)
        }
        #endregion

        #region Argument Objects
        public void SomeFunction()
        {
            Customer customer = new Customer();
            Product product = new Product();

            double price = CalculatePrice(customer, product, 10, false, DeliveryMethod.Prime);

            OrderRequest request = new OrderRequest(customer, product, 10, false, DeliveryMethod.Prime);
            price = CalculatePrice(request);

        }

            #region set 1, Multiple Parameters
            public double CalculatePrice(
                Customer customer,
                Product product,
                int quantity, 
                bool isGift,
                DeliveryMethod deloveryMethod)
            {
                double discountRate = getDiscountRate(customer, product, quantity, isGift, deloveryMethod);
                double deliveryCost = getDeliveryCost(customer, product, quantity, isGift, deloveryMethod);
                return (quantity * product.Price * discountRate) + deliveryCost;
            }

            private double getDiscountRate(
                Customer customer,
                Product product,
                int quantity,
                bool isGift,
                DeliveryMethod deloveryMethod)
            {
                // Calculate discount
                return 1;
            }

            private double getDeliveryCost(
                Customer customer,
                Product product,
                int quantity,
                bool isGift,
                DeliveryMethod deloveryMethod)
            {
                return 0;
            }
        #endregion

            #region set 2, request object
            public double CalculatePrice(
                OrderRequest request)
            {
                double discountRate = getDiscountRate(request);
                double deliveryCost = getDeliveryCost(request);
                return (request.CalculateTotalPrice() * discountRate) + deliveryCost;
            }

            private double getDiscountRate(
                OrderRequest request)
            {
                // Calculate discount
                return 1;
            }

            private double getDeliveryCost(
                OrderRequest request)
            {
                return 0;
            }
            #endregion

        #endregion
    }

    internal class OrderRequest
    {
        private Customer customer;
        private Product product;
        private int quantity;
        private bool isGift;
        private DeliveryMethod prime;

        public OrderRequest(
            Customer customer,
            Product product,
            int quantity,
            bool isGift,
            DeliveryMethod prime)
        {
            this.customer = customer;
            this.product = product;
            this.quantity = quantity;
            this.isGift = isGift;
            this.prime = prime;
        }

        internal double CalculateTotalPrice()
        {
            return this.quantity * this.product.Price;
        }
    }

    enum DeliveryMethod
    {
        Prime
    }
}
