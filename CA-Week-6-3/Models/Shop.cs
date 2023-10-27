using System;

namespace CA_Week_6_3.Models
{
    internal class Shop
    {
        public List<Order> Orders = new();


        public void AddOrder(Order o)
        {
            Orders.Add(o);
        }

        public double GetAvgPrice()
        {
            double avg = 0;
            foreach(Order o in Orders)
            {
                avg += o.TotalAmount;
            }

            return Orders.Count > 0 ? Math.Round(avg / Orders.Count, 2) : 0;
        }

        public double GetAvgPrice(DateTime date)
        {
            double avg = 0;
            int count = 0;
            foreach (Order o in Orders)
            {
                if (o.CreatedAt > date) {
                    avg += o.TotalAmount;
                    count++;
                }
            }

            return count > 0 ? Math.Round(avg / count, 2) : 0;
        }

        public void RemoveOrderByNo(int no)
        {
            for(int i = Orders.Count - 1; i > -1; i--)
            {
                Order o = Orders[i];
                if (o.No == no) Orders.RemoveAt(i);
            }
        }

        public List<Order> FilterOrdersByPrice(double minPrice, double maxPrice)
        {
            List<Order> _ = new();
            foreach(Order o in Orders)
            {
                double price = o.TotalAmount;
                if (price >= minPrice && price <= maxPrice) _.Add(o);
            }
            return _;
        }
    }
}
