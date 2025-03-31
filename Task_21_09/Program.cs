using System.Net.Sockets;

namespace Task_21_09
{
    internal class Program
    {
//        создайте класс билета(Ticket). сгенерируйте список из 30 билетов.произведите:
//• поиск билета с максимальной суммой,
//• билета с минимальной суммой,
//• выведите список билетов с багажом
//• выведите список люготных билетов
        static void Main(string[] args)
        {
            List<Ticket> tickets = GenerateTickets(30);
            Ticket maxTicket = tickets.OrderByDescending(t => t.Sum).FirstOrDefault();
            Ticket minTicket = tickets.OrderBy(t => t.Sum).FirstOrDefault();
            List<Ticket> bagageTickets = tickets.Where(t => t.HasBagage).ToList();
            List<Ticket> discountedTickets = tickets.Where(t => t.IsDiscounted).ToList();

            Console.WriteLine($"максимал сумма: {maxTicket?.Sum}, билет: {maxTicket?.Id}");
            Console.WriteLine($"минимал сумма: {minTicket?.Sum}, билет: {minTicket?.Id}");
            Console.WriteLine("\nбилеты с багажом:");
            foreach (var ticket in bagageTickets)
            {
                Console.WriteLine($"ID: {ticket.Id}, сумма: {ticket.Sum}");
            }
            Console.WriteLine("\nльготные билеты:");
            foreach (var ticket in discountedTickets)
            {
                Console.WriteLine($"ID: {ticket.Id}, сумма: {ticket.Sum}");
            }
        }
        static List<Ticket> GenerateTickets(int count)
        {
            Random random = new Random();
            List<Ticket> tickets = new List<Ticket>();
            for (int i = 1; i <= count; i++)
            {
                tickets.Add(new Ticket
                {
                    Id = i,
                    Sum = random.Next(100, 1000),
                    HasBagage = random.Next(0, 2) == 1,
                    IsDiscounted = random.Next(0, 2) == 1 
                });
            }
            return tickets;
        }
    }
}
