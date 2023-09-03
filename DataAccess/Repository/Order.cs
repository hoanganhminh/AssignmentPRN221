using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.Repository
{
    public partial class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int OrderId { get; set; }
        public int? MerberId { get; set; }
        public DateTime OrderdDate { get; set; }
        public DateTime? RequiredDate { get; set; }
        public DateTime? ShippedDate { get; set; }
        public decimal? Freight { get; set; }

        public virtual Member Merber { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
