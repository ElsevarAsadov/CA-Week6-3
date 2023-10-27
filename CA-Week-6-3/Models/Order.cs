using System;

namespace CA_Week_6_3.Models
{
    internal class Order
    {
        private static int _no = 1;
        public int No { get; set; }
        public string Name { get; set; }
        public int ProductCount { get; set; }
        public double Price {get; set;}
        public double TotalAmount { get; set; }
        public DateTime CreatedAt { get; set; }

        public Order(string name, int count, double price, DateTime date)
        {
            Name = name;
            ProductCount = count;
            Price = price;
            CreatedAt = date;
            No = Order._no;

            TotalAmount = Price * ProductCount;
            
            Order._no++;
        }

        public override string ToString()
        {
            return $"{No} - {Name} - {Price}$ - {ProductCount} - {TotalAmount}$ - {CreatedAt}";
        }
    }
}
