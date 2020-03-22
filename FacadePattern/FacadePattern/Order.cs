namespace FacadePattern
{
    public class Order
    {
        public string DishName { get; set; }
        public double DishPrice { get; set; }
        public string User { get; set; }
        public string ShippingAddress { get; set; }
        public double ShippingPrice { get; set; }

        public override string ToString()
        {
            return string.Format("User {0} ordered {1}. The full price is {2} dollars.",
                User, DishName, DishPrice + ShippingPrice);
        }
    }
}