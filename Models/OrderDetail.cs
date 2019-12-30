using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreTutorial.Models
{
    public class OrderDetail
    {
        public int OrderDetailID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }

        public Order Order;

        public Order GetOrder()
        {
            return Order;
        }
    }
}
