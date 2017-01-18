using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace booklib
{
   public class calculate
    {
        public static Double CalBooks(List<Order> books)
        {
            Double total = 0;
            int package = 1;
            while (books.Any(x => x.quantity >= package))
            {
                var pack = books.Where(x => x.quantity >= package);

               

                total += pack.Sum(x => x.book.price) * caldiscount(pack);
                package++;
            }

            return total;
        }

        private static double caldiscount(IEnumerable<Order> pack)
        {
            double discount = 1;

            if (pack.Count() == 2)
            {
                discount = 0.95;
            }
            if (pack.Count() == 3)
            {
                discount = 0.9;
            }
            if (pack.Count() == 4)
            {
                discount = 0.8;
            }
            if (pack.Count() == 5)
            {
                discount = 0.75;
            }

            return discount;
        }
    }
}
