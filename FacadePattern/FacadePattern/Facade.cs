using System.Collections.Generic;

namespace FacadePattern
{
    public class Facade
    {
        private readonly OnlineRestaurant _restaurant;
        private readonly ShippingService _shippingService;

        public Facade(OnlineRestaurant restaurant, ShippingService shippingService)
        {
            _restaurant = restaurant;
            _shippingService = shippingService;
        }

        public void OrderFood(List<Order> orders)
        {
            foreach (var order in orders)
            {
                _restaurant.AddOrderToCart(order);
            }

            _restaurant.CompleteOrders();

            foreach (var order in orders)
            {
                _shippingService.AcceptOrder(order);
                _shippingService.CalculateShippingExpenses();
                _shippingService.ShipOrder();
            }
        }
    }
}