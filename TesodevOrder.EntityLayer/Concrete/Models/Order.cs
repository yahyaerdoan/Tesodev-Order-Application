using System;
using System.Collections.Generic;

#nullable disable

namespace TesodevOrder.EntityLayer.Concrete.Models
{
    public partial class Order
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string Status { get; set; }
        public Guid AddressId { get; set; }
        public Guid ProductId { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }

        public virtual Address Address { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Product Product { get; set; }
    }
}
