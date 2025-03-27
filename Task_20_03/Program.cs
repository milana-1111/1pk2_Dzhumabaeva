namespace Task_20_03
{

    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();

            order.ChangeStatus(OrderStatus.Processing);
            order.ChangeStatus(OrderStatus.Shipped);
            order.ChangeStatus(OrderStatus.Delivered);

            order.ChangeStatus(OrderStatus.Cancelled); // Попытка изменить статус после доставки
        }
    }
}

