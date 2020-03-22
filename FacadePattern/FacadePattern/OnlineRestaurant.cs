using System;
using System.Collections.Generic;

namespace FacadePattern
{
    public class OnlineRestaurant
    {
        private readonly List<Order> _cart;

        public OnlineRestaurant()
        {
            _cart = new List<Order>();
        }

        public void AddOrderToCart(Order order)
        {
            _cart.Add(order);
        }

        public void CompleteOrders()
        {
            Console.WriteLine("Orders completed. Dispatch in progress...");
        }
    }
}