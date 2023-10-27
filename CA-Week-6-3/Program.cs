using CA_Week_6_3.Models;

namespace CA_Week_6_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order o1 = new Order("Big Mac", 2, 5, new DateTime(

                year: 2023, month: 10, day: 27, hour: 4, minute: 12, second: 3)

                );

            Order o2 = new Order("Chicken Wings", 10, 2, new DateTime(

                year: 2023, month: 10, day: 27, hour: 4, minute: 13, second: 13)

                );

            Order o3 = new Order("Chicken Wings", 5, 2, new DateTime(

                year: 2023, month: 10, day: 27, hour: 4, minute: 16, second: 13)

                );

            Shop Macdonalds = new Shop();

            Macdonalds.AddOrder(o1);
            Macdonalds.AddOrder(o2);
            Macdonalds.AddOrder(o3);

            //Macdonalds.RemoveOrderByNo(1);

            foreach (Order o in Macdonalds.Orders)
            {
                //Console.WriteLine(o);
            }

            foreach (Order o in Macdonalds.FilterOrdersByPrice(15, 20))
            {
                //Console.WriteLine(o);
            }



            //Console.WriteLine(Macdonalds.GetAvgPrice());

            /*Console.WriteLine(Macdonalds.GetAvgPrice(

                new DateTime(

                    year: 2023, month: 10, day: 27, hour: 4, minute: 13, second: 11)

                    )

                );*/

        }
    }
}