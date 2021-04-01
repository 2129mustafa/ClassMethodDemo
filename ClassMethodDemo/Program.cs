using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "Mustafa";
            customer1.LastName = "Yenal";
            customer1.City = "Balıkesir";

            Customer customer2 = new Customer()//farklı bir kullanım
            {
                Id = 2,
                FirstName = "Engin",
                LastName = "Demiroğ",
                City = "Ankara"
            };

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.LastName = "Burak";
            customer3.FirstName = "Kara";
            customer3.City = "İstanbul";

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            Console.WriteLine("---------------------------\n");
            customerManager.Update(customer2);
            Console.WriteLine("---------------------------\n");
            customerManager.Delete(customer3);
            Console.WriteLine("---------------------------\n");


        }
    }
}
