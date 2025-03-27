namespace Task_20_03
{
//    Создайте программу для управления статусом заказа в интернет-магазине.Используйте перечислениеOrderStatus со значениями:
//• New(новый)
//• Processing(в обработке)
//• Shipped(отправлен)
//• Delivered(доставлен)
//• Cancelled(отменён)
//Напишите метод, который меняет статус заказа.Если заказ уже доставлен или отменён, запретите изменение статуса.Выводите сообщение при каждом изменении статуса (например,
//"Заказ переведён в статус: Отправлен").
    public class Order
    {
        public OrderStatus Status { get; private set; }

        public Order()
        {
            Status = OrderStatus.New;
            Console.WriteLine("Заказ создан. Статус: Новый");
        }
        public void ChangeStatus(OrderStatus newStatus)
        {
            if (Status == OrderStatus.Delivered || Status == OrderStatus.Cancelled)
            {
                Console.WriteLine("Невозможно изменить статус: заказ уже доставлен или отменён.");
                return;
            }

            Status = newStatus;
            Console.WriteLine($"Заказ переведён в статус: {Status}");
        }
    }
}

