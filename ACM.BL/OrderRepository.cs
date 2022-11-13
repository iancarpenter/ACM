namespace ACM.BL
{
    public class OrderRepository
    {
        public Order Retrieve(int orderId)
        {
            // create the instance of the order class
            // pass in the requested id
            Order order = new Order(orderId);

            if (orderId == 3)
            {
                order.OrderDate = DateTime.Now;                
            }

            return order;
        }

        public bool Save(Order order)
        {
            return true;
        }
    }
}
