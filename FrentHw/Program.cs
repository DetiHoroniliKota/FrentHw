using System;
using Microsoft.EntityFrameworkCore.SqlServer;
using System.Linq;


namespace FrentHw
{
    class Program
    {
        static void Main(string[] args)
        {
            //Добавление
            using (ApplicationContext db = new ApplicationContext())
            {
                Order order1 = new Order
                {
                    DatеBegin = DateTime.Now,
                    Customer = new User { Name = "Tom", Age = 22 },
                    Summ = 111,
                    Description = "Падла такая"
                };

                Order order2 = new Order
                {
                    DatеBegin = DateTime.Now,
                    Customer = new User { Name = "Max", Age = 34 },
                    Summ = 222,
                    Description = "Падла сякая"
                };

                Order order3 = new Order
                {
                    DatеBegin = DateTime.Now,
                    Customer = new User { Name = "Tom", Age = 22 },
                    Summ = 333,
                    Description = "слон больше собаки"
                };

                db.Orders.Add(order1);
                db.Orders.Add(order2);
                db.Orders.Add(order3);
            }
            
            //получение
            using (ApplicationContext db = new ApplicationContext())
            {
                // получаем объекты из бд и выводим на консоль
                var orders = db.Orders.ToList();
                Console.WriteLine("Данные после добавления:");
                foreach (Order o in orders)
                {
                    Console.WriteLine($"{o.Id}");
                }
            }
            
            // Редактирование
            using (ApplicationContext db = new ApplicationContext())
            {
                // получаем первый объект
                Order? order = db.Orders.FirstOrDefault();
                if (order != null)
                {
                    order.Summ = 444;
                    //обновляем объект
                    //db.Users.Update(user);
                    db.SaveChanges();
                }

                // выводим данные после обновления
                Console.WriteLine("\nДанные после редактирования:");
                var orders = db.Orders.ToList();
                foreach (Order o in orders)
                {
                    Console.WriteLine($"{o.Id}.{o.DatеBegin}.{o.Summ}.{o.Customer}");
                }
            }
        }

    }
}
